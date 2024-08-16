using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProductManagementSystem.Infra.Data.Context
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer("DefaultConnection");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
