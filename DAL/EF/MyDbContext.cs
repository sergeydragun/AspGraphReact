using DAL.EF.Configuartions;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class MyDbContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<InfoCard> InfoCards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new InfoCardEntityConfiguration());
        }

    }
}
