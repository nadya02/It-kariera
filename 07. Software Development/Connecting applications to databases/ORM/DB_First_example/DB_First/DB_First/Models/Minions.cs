using System;
using System.Collections.Generic;

namespace DB_First.Models
{
    public partial class Minions
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public long TownId { get; set; }

        public virtual Towns Town { get; set; }
    }
}
