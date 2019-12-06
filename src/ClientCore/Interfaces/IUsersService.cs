using MessageServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat.ClientCore.Interfaces
{
    public interface IUsersService
    {
        Task<Result> Register(string username, string email, string password);
        Task<Result> RegisterExternalUser(string username, string email);
    }
}
