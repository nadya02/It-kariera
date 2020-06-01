using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Family
    {
        private List<Person> members = new List<Person>();

        public List<Person> Names
        {
            get { return this.members; }
            set { this.members = value; }
        }

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public Person GetOldestMember()
        {
            return members.OrderByDescending(x => x.Age).First();
        }
    }
}
