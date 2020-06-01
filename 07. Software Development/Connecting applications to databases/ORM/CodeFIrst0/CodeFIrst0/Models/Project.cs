using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstDB.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<EmployeeProject> EmployeeProject { get; set; }
    }
}
