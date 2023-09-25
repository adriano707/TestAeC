using Microsoft.EntityFrameworkCore;
using System.Reflection;
using User.Domain.Entities;
using User.Domain.Entities.Address;

namespace User.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<Domain.Entities.User> User { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Address> Addresse { get; set; }
        public DbSet<Occupation> Occupations { get; set; }

        public UserDbContext(){}

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
