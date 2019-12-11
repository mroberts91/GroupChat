using GroupChat.ClientCore.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat.ClientCore.Interfaces
{
    public interface ICurrentUserService
    {
        Task<AuthenticatedUser> CurrentUser();
    }
}
