using System;
using System.Collections.Generic;

namespace DB_First.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Towns = new HashSet<Towns>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Towns> Towns { get; set; }
    }
}
