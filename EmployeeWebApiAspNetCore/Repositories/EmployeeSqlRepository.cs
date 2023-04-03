using EmployeeWebApiAspNetCore.Entities;
using EmployeeWebApiAspNetCore.Helpers;
using System.Linq.Dynamic.Core;

namespace EmployeeWebApiAspNetCore.Repositories
{
    public class EmployeeSqlRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeSqlRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public EmployeeEntity GetEmployee(int id)
        {
            return _employeeDbContext.Employees.FirstOrDefault(x => x.Id == id);
        }

        public void Add(EmployeeEntity item)
        {
            _employeeDbContext.Employees.Add(item);
        }

        public void Delete(int id)
        {
            EmployeeEntity employee = GetEmployee(id);
            _employeeDbContext.Employees.Remove(employee);
        }

        public EmployeeEntity Update(int id, EmployeeEntity item)
        {
            _employeeDbContext.Employees.Update(item);
            return item;
        }

        public IQueryable<EmployeeEntity> GetAll()
        {
            IQueryable<EmployeeEntity> _allItems = _employeeDbContext.Employees.OrderByDescending(emp => emp.Id);

            return _allItems;
                
        }

        public int Count()
        {
            return _employeeDbContext.Employees.Count();
        }

        public bool Save()
        {
            return (_employeeDbContext.SaveChanges() >= 0);
        }

        public ICollection<EmployeeEntity> GetEmployeesList()
        {
            List<EmployeeEntity> employees = new List<EmployeeEntity>();

            //toReturn.Add(GetRandomItem("Starter"));
            //toReturn.Add(GetRandomItem("Main"));
            //toReturn.Add(GetRandomItem("Dessert"));

            return employees;
        }
    }
}
