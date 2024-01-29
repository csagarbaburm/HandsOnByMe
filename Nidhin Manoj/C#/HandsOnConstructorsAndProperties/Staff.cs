using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties
{
    internal class Staff
    {
        private int id;
        public string name;
        public Staff (int id, string name)//constructor
        {
            this.id = id;
            this.name = name;
        }
        public Staff(Staff staff) 
        {
        
            this.id = staff.id;
                this.name = staff.name;
        }

        public void Display()
        {
            Console.WriteLine($"id:{id} name:{name}");
        }
    }

    class Test_Staff
    {
        static void Main()
        {
            Staff s = new Staff(3223, "sanal");
            s.Display();
            Staff s1 = new Staff(2345, "shebin");
            s1.Display();
            Staff[] staffs = new Staff[3];
            staffs[0] = s1;


            staffs[1] = new Staff(s);
            s.name = "raanjan";
            staffs[2] =new Staff (2344,"mary");
            foreach(Staff ss in staffs)
            {
                ss.Display();
            }


        }
    }
}
