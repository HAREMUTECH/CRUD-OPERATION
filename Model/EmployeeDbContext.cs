using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decloud_CRUD.Model
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext()
        {
        }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            :base(options)
        {

        }

        public DbSet<TblCities> Cities { get; set; }
        public DbSet<TblEmployee> Employees { get; set; }

    }
}
