using EmployeeWebApiAspNetCore.Repositories;

namespace EmployeeWebApiAspNetCore.Services
{
    public interface ISeedDataService
    {
        void Initialize(EmployeeDbContext context);
    }
}
