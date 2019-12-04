using CleanArchitecture.Infrastructure.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.TodoLists.Commands.CreateTodoList;
using CleanArchitecture.Application.TodoLists.Queries.GetTodos;
using CleanArchitecture.Application.TodoItems.Commands.CreateTodoItem;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "user@clean-arch", Email = "user@clean-arch" };

            if (!userManager.Users.Any(u => u.Id == defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, "CleanArch!1");
            }
            


        }
    }
}
