using LInqAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqAssignment
{
    internal class Ques7
    {
        public static void Main(string[] args)
        {
            List<Order> orderlist = new List<Order>()
            {
               new Order {OrderId=11,ItemName="A",Quantity=100,OrderDate=new DateTime(2023,1,30),},
                new Order {OrderId=12,ItemName="B",Quantity=2100,OrderDate=new DateTime(2023,2,15),},
                new Order {OrderId=13,ItemName="C",Quantity=1001,OrderDate=new DateTime(2023,3,30),},
                new Order {OrderId=14,ItemName="D",Quantity=95,OrderDate=new DateTime(2023,4,30),},
                new Order {OrderId=15,ItemName="E",Quantity=50,OrderDate=new DateTime(2023,5,30),},
                new Order {OrderId=16,ItemName="F",Quantity=8900,OrderDate=new DateTime(2023,1,30),},
                new Order {OrderId=17,ItemName="G",Quantity=140,OrderDate=new DateTime(2023,12,30),},
                new Order {OrderId=18,ItemName="H",Quantity=2320,OrderDate=new DateTime(2023,1,30),},

            };





            IEnumerable<Order> objs = from order1 in orderlist
                                      where order1.Quantity == 0
                                      select order1;
            if (objs.Count() < 0)
            {
                Console.WriteLine("No orders below 0");
            }



            var resultFinal = (from order1 in orderlist
                               orderby order1.Quantity descending
                               select order1).FirstOrDefault();



            Console.WriteLine($"The order with largest quantity: {resultFinal}");



            int objsJan2024 = (from order1 in orderlist
                               where order1.OrderDate < new DateTime(2024, 1, 1)
                               select order1).Count();


            if (objsJan2024 > 0)
            {
                Console.WriteLine($"There are {objsJan2024} orders before Jan2024");
            }


        }

    }
}
