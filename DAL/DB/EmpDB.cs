using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB
{
    public class EmpDB : DbContext
    {
        public EmpDB():base("name=Defalut")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
