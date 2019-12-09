using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.BlazorClient.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _config;
        public AccountController(IConfiguration configuration)
        {
            _config = configuration;
        }
        public IActionResult SignIn()
        {
            return Challenge(
                new AuthenticationProperties { RedirectUri = Url.Content("~/") },
                "oidc");
        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync("Cookies");
            await HttpContext.SignOutAsync("oidc");

            return SignOut(
                new AuthenticationProperties { RedirectUri = Url.Content("~/") },
                "oidc");
        }

        public IActionResult Register()
        {
            var authority = _config.GetSection("Authentication").GetValue<string>("Authority");
            var registerEndpoint = _config.GetSection("Authentication:Endpoints").GetValue<string>("Register");
            var registrationReturn = _config.GetSection("Authentication").GetValue<string>("RegistrationRedirect");
            var redirectUrl = $"{authority}/{registerEndpoint}?returnUrl={Url.Content(registrationReturn)}";
            return Redirect(redirectUrl);
        }
    }
}
