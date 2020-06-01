using System;
using System.Collections.Generic;

namespace DB_First.Models
{
    public partial class Villians
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long EvilnessFactorId { get; set; }

        public virtual EvilnessFactors EvilnessFactor { get; set; }
    }
}
