using Microsoft.EntityFrameworkCore;
using EmployeeWebApiAspNetCore.Entities;

namespace EmployeeWebApiAspNetCore.Repositories
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options) { }

        public DbSet<EmployeeEntity> Employees { get; set; } = null!;
    }
}
