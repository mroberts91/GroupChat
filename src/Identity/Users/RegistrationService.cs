using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GroupChat.Identity.Interfaces;

namespace GroupChat.Identity.Users
{
    public class RegistrationService : IRegistrationService
    {
        private readonly UserManager<IdentityUser> _userManager;

        public RegistrationService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateUserAsync(string userName, string email, string password)
        {
            var user = new IdentityUser { UserName = userName, Email = email };

            var result = await _userManager.CreateAsync(user, password);

            return result;
        }
    }
}
