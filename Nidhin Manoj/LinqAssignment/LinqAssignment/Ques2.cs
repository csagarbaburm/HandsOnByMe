using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqAssignment
{
    class Player
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }

    internal class Ques2
    {
        public static void Main(string[] args)
        {
            List<Player> list1 = new List<Player>()
            {
                new Player(){Name="Amal", Country="India"},
                new Player(){Name="Bibin", Country="Pakistan"},
                new Player(){Name="Chris", Country="Sri Lanka"},
                new Player(){Name="Dony", Country="Nepal"},
                new Player(){Name="Fredy", Country="Australia"},
                new Player(){Name="Adithya", Country="Nepal"},
                new Player(){Name="Hani", Country="India"},
            };
            List<Player> list2 = new List<Player>()
            {
                new Player(){Name="Antony", Country="India"},
                new Player(){Name="Bony", Country="Pakistan"},
                new Player(){Name="Blesson", Country="Sri Lanka"},
                new Player(){Name="Chacko", Country="Nepal"},
                new Player(){Name="Akash", Country="China"},
                new Player(){Name="Achu", Country="China"},
                new Player(){Name="Aju", Country="India"},
            };


            var matches = from p1 in list1
                          from p2 in list2
                          where p1.Country != p2.Country
                          select p1.Name + " ~vs~ " + p2.Name;

            foreach (var p in matches)
            {
                Console.WriteLine(p);
            }
        }
    }
}