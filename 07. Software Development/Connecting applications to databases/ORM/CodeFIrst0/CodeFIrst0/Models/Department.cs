using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstDB.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees {get; set; }
    }
}
