using LeopardType.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LeopardType.EF
{
    class PasswordDBContext : DbContext
    {

        public DbSet<Passwords>? Password { get; set; }


    }
}