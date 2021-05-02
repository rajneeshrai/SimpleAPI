using Microsoft.EntityFrameworkCore;
using SimpleAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAPI.Database
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        DbSet<Employee> Employees { get; set; }
    }
}
