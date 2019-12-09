using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Identity.Users
{
    public class ApplicationUserContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationUserContext(DbContextOptions<ApplicationUserContext> options)
           : base(options)
        {
        }
    }
}
