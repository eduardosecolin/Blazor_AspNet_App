using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_AspNet_App.Models;

namespace Blazor_AspNet_App.DataManager.EmployeeServices
{
    public class EmployeeService
    {
        private readonly EmployeeAccessLayer eal = new EmployeeAccessLayer();

        public Task<List<Tbcolaboradore>> GetAllEmployee()
        {
            return Task.FromResult(eal.GetAll());
        }

        public Task<Tbcolaboradore> GetEmployeeById(int id)
        {
            return Task.FromResult(eal.GetById(id));
        }

        public void Create(Tbcolaboradore employee)
        {
            eal.Post(employee);
        }

        public void Update(Tbcolaboradore employee)
        {
            eal.Edit(employee);
        }

        public void DeleteEmployee(int id)
        {
            eal.Delete(id);
        }

        public Task<List<Tbcidade>> GetCitiesEmployee()
        {
            return Task.FromResult(eal.GetCities());
        }
    }
}
