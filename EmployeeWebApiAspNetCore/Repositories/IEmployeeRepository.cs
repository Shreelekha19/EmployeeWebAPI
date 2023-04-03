using EmployeeWebApiAspNetCore.Entities;

namespace EmployeeWebApiAspNetCore.Repositories
{
    public interface IEmployeeRepository
    {
        EmployeeEntity GetEmployee(int id);
        void Add(EmployeeEntity item);
        void Delete(int id);
        EmployeeEntity Update(int id, EmployeeEntity item);
        IQueryable<EmployeeEntity> GetAll();
        ICollection<EmployeeEntity> GetEmployeesList();
        int Count();
        bool Save();
    }
}
