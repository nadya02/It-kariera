using System;
using System.Collections.Generic;

namespace DB_First.Models
{
    public partial class Towns
    {
        public Towns()
        {
            Minions = new HashSet<Minions>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long CountryCode { get; set; }

        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual ICollection<Minions> Minions { get; set; }
    }
}
