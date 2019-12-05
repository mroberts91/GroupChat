using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.ClientCore.Interfaces
{
    public interface IRpcServiceProvider
    {
        IUsersService UserService { get; }
    }
}
