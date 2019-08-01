using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_AspNet_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_AspNet_App.DataManager.EmployeeServices
{
    public class EmployeeAccessLayer
    {
        private EmployeeContext _context = new EmployeeContext();

        public List<Tbcolaboradore> GetAll()
        {
            try
            {
                return _context.Tbcolaboradores.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Tbcolaboradore GetById(int id)
        {
            try
            {
                var employee = _context.Tbcolaboradores.Find(id);
                _context.Entry(employee).State = EntityState.Detached;
                return employee;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Post(Tbcolaboradore employee)
        {
            try
            {
                _context.Tbcolaboradores.Add(employee);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(Tbcolaboradore employee)
        {
            try
            {
                _context.Entry(employee).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var employee = _context.Tbcolaboradores.Find(id);
                _context.Remove(employee);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Tbcidade> GetCities()
        {
            try
            {
                return _context.Tbcidades.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
