using EmployeeWebApiAspNetCore.Entities;
using EmployeeWebApiAspNetCore.Repositories;

namespace EmployeeWebApiAspNetCore.Services
{
    public class SeedDataService : ISeedDataService
    {
        public void Initialize(EmployeeDbContext context)
        {
            context.Employees.Add(
                new EmployeeEntity()
                {
                    FirstName = "Lekha",
                    CityName = "Starter",
                    YearOfJoining = DateTime.Now,
                }
            );

            context.SaveChanges();
        }
    }
}
