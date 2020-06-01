using System;
using System.Collections.Generic;

namespace DB_First.Models
{
    public partial class EvilnessFactors
    {
        public EvilnessFactors()
        {
            Villians = new HashSet<Villians>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Villians> Villians { get; set; }
    }
}
