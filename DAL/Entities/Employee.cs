using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Dob { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
