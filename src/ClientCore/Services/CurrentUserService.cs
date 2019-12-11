using GroupChat.ClientCore.Common.Exceptions;
using GroupChat.ClientCore.Interfaces;
using GroupChat.ClientCore.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat.ClientCore.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _accessor;
        public CurrentUserService(IHttpContextAccessor contextAccessor)
        {
            _accessor = contextAccessor;
        }

        public async Task<AuthenticatedUser> CurrentUser()
        {
            try
            {
                var name = _accessor.HttpContext.User.Identity.Name;
                var email = _accessor.HttpContext.User.FindFirst("email")?.Value;
                var token = await _accessor.HttpContext.GetTokenAsync("access_token");
                return new AuthenticatedUser(name, email, token);
            }
            catch (ArgumentNullException ex)
            {
                throw new UnauthenticatedUser("Unable to access an authenticated user from the current context", ex);
            }
            catch (ArgumentException ex)
            {
                throw new UnauthenticatedUser("Unable to access an authenticated user from the current context", ex);
            }
        }
    }
}
