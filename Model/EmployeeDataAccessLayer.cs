using Decloud_CRUD.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decloud_CRUD.Model
{
    public class EmployeeDataAccessLayer: IEmployee
    {
        private EmployeeDbContext db;

        public EmployeeDataAccessLayer(EmployeeDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<TblEmployee> GetAllEmployees()
        {
            try
            {
                return db.Employees.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record   
        public int AddEmployee(TblEmployee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee  
        public int UpdateEmployee(TblEmployee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee  
        public TblEmployee GetEmployeeData(int id)
        {
            try
            {
                TblEmployee employee = db.Employees.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee  
        public int DeleteEmployee(int id)
        {
            try
            {
                TblEmployee emp = db.Employees.Find(id);
                db.Employees.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Get the list of Cities  
        public List<TblCities> GetCities()
        {
            List<TblCities> lstCity = new List<TblCities>();
            lstCity = (from CityList in db.Cities select CityList).ToList();

            return lstCity;
        }
    }
}

