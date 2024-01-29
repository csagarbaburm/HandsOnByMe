using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Staff
    {
        public int staffId;
        public string staffName;
        public static string school;
        public static string branch;
        public const string city = "Kottayam";
        public string Display()
        {
            return $"ID:{staffId} name:{staffName} school{school} branch:{branch} city:{city}";
        }
        static void Main()
        {
            Staff.school = "AKM";
            Staff.branch = "cse";
            Staff s1 = new Staff()
            {
                staffId = 1,
                staffName = "jomon"
            };
            Staff s2 = new Staff()
            {
                staffId = 2,
                staffName = "jomol"
            };
            Console.WriteLine(s1.Display());
            Console.WriteLine(s2.Display());

        }
    }
}
