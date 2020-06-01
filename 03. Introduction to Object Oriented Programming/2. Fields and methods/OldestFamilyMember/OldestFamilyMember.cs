using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class OldestFamilyMember
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            int n = int.Parse(Console.ReadLine());
            Family myfamily = new Family();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var split_input = input.Split();
                Person p = new Person();
                p.Name = split_input[0];
                p.Age = int.Parse(split_input[1]);
                myfamily.AddMember(p);
            }

            Person oldest = myfamily.GetOldestMember();
            Console.WriteLine(oldest.Name + " " + oldest.Age);
        }
    }
}
