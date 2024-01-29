using LInqAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqAssignment
{

    internal class Ques6
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

            List<Item> itemlist = new List<Item>()
            {
                new Item(){ItemName="A",Price=500.0f },
                new Item(){ItemName="B",Price=50.0f },
                new Item(){ItemName="C",Price=200.0f },
                new Item(){ItemName="D",Price=700.0f },
                new Item(){ItemName="E",Price=900.0f },
                new Item(){ItemName="F",Price=30.0f },
                new Item(){ItemName="G",Price=80.0f },
                new Item(){ItemName="H",Price=230.0f }


            };

            var result = from order1 in orderlist
                         join item1 in itemlist
                         on order1.ItemName equals item1.ItemName

                         select new { id = +order1.OrderId, name = order1.ItemName, date = order1.OrderDate, total = order1.Quantity * item1.Price };


            var resultFinal = from order1 in result
                              orderby order1.date descending
                              group order1 by order1.date.Month;




            foreach (var order in resultFinal)
            {
                Console.WriteLine($"Order of month:{order.Key}");
                foreach (var item in order)
                {
                    Console.WriteLine($"ID: {item.id} Name:{item.name} Total:{item.total} Date:{item.date}");
                }


            }



        }


    }
}
