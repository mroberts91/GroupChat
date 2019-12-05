using GroupChat.Infrastructure.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using GroupChat.Application.TodoLists.Commands.CreateTodoList;
using GroupChat.Application.TodoLists.Queries.GetTodos;
using GroupChat.Application.TodoItems.Commands.CreateTodoItem;

namespace GroupChat.Infrastructure.Persistence
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
