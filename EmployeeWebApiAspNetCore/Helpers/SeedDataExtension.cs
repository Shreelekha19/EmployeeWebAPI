using EmployeeWebApiAspNetCore.Repositories;
using EmployeeWebApiAspNetCore.Services;

namespace EmployeeWebApiAspNetCore.Helpers
{
    public static class SeedDataExtension
    {
        public static void SeedData(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<EmployeeDbContext>();
                var seedDataService = scope.ServiceProvider.GetRequiredService<ISeedDataService>();

                seedDataService.Initialize(dbContext);
            }
        }
    }
}
