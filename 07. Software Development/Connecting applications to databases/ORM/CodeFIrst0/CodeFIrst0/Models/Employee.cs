using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstDB.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int DeparmentId { get; set; } 
        public Department department { get; set;}

        public ICollection <EmployeeProject> EmployeeProject { get; set;}
    }
}
