using Atomic.Test.AeC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Atomic.TestAeC.Data
{
    public class TestAeCDbContext : DbContext
    {
        public TestAeCDbContext()
        {
            
        }

        public TestAeCDbContext(DbContextOptions<TestAeCDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
