using System;
using System.Collections.Generic;

namespace DB_First.Models
{
    public partial class MinionsVillians
    {
        public long MinionId { get; set; }
        public long VillianId { get; set; }

        public virtual Minions Minion { get; set; }
        public virtual Villians Villian { get; set; }
    }
}
