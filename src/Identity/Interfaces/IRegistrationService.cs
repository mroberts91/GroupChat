using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Identity.Interfaces
{
    public interface IRegistrationService
    {
        Task<IdentityResult> CreateUserAsync(string userName, string email, string password);
    }
}
