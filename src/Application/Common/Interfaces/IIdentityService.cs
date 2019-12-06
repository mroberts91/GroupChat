using GroupChat.Application.Common.Models;
using System.Threading.Tasks;

namespace GroupChat.Application
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string email, string password);

        Task<Result> DeleteUserAsync(string userId);

        Task<(string token, string userId)> CreateExternalAuthUser(string username, string email);
    }
}
