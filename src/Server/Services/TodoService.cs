using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CleanArchitecture.Application.TodoLists.Queries.GetTodos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MessageServices;

namespace Server.Services
{
    public class TodoService : Todo.TodoBase
    {
        private readonly IMediator _mediator;
        public TodoService(IHttpContextAccessor contextAccessor)
        {
            var context = contextAccessor.HttpContext;
            _mediator = context.RequestServices.GetService<IMediator>();
        }
        public override async Task<TodoLists> AllTodoLists(Empty request, ServerCallContext context)
        {
            var response = new TodoLists();
            var todos = await _mediator.Send(new GetTodosQuery());
            var messageLists = new List<TodoList>();
            foreach (var list in todos.Lists)
            {
                var items = new List<TodoItem>();
                foreach (var item in list.Items)
                {
                    items.Add(MapMessageFromQuery<TodoItem, TodoItemDto>(item));
                }
                var todoList = MapMessageFromQuery<TodoList, TodoListDto>(list, "Items");
                todoList.Items.AddRange(items);
                messageLists.Add(todoList);
            }

            response.Lists.AddRange(messageLists);
            return response;

        }

        private T MapMessageFromQuery<T, TSource>(TSource source, params string[] ignore)
        {
            if (source is null)
                throw new ArgumentNullException("Unable to map message due to source object not in an instantiated state.");

            bool canMap = false;
            var mapableProperties = new List<PropertyInfo>();
            var requestedType = typeof(T);
            var sourceType = typeof(TSource);
            var requestedProperties = TypeAndName(requestedType.GetProperties());
            var sourceProperties = TypeAndName(sourceType.GetProperties());
            foreach (var prop in sourceProperties)
            {
                if (requestedProperties.Contains(prop) && !ignore.Contains(prop.Value))
                {
                    canMap = true;
                    mapableProperties.Add(sourceType.GetProperty(prop.Value));
                }
            }

            if (!canMap || mapableProperties.Count < 1)
                throw new InvalidCastException("Unable to map source to the requested type because there are no matching properites");

            var mappedObject = Activator.CreateInstance(typeof(T));
            foreach (var prop in mapableProperties)
            {
                var value = source.GetType().GetProperty(prop.Name).GetValue(source, null);
                mappedObject.GetType().GetProperty(prop.Name).SetValue(mappedObject, value);
            }
            return (T)mappedObject;
        }

        private Dictionary<System.Type, string> TypeAndName(PropertyInfo[] properties)
        {
            var dict = new Dictionary<System.Type, string>();
            foreach (var prop in properties)
            {
                dict.Add(prop.PropertyType, prop.Name);
            }
            return dict;
        }
    }
}
