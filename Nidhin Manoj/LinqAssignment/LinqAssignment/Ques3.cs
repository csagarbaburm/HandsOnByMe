using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqAssignment
{

    public class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

    }
    internal class Ques3
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

            var result = from order1 in orderlist
                         orderby order1.OrderDate descending
                         select order1;

            Console.WriteLine("Recent to Oldest Order...");


            foreach (var order in result)
            {
                Console.WriteLine($"ID: {order.OrderId} Name:{order.ItemName} Quantity:{order.Quantity} Date:{order.OrderDate}");
            }


            Console.WriteLine("Highest to Lowest Quantity...");

            result = from order1 in orderlist
                     orderby order1.Quantity descending
                     select order1;

            foreach (var order in result)
            {
                Console.WriteLine($"ID: {order.OrderId} Name:{order.ItemName} Quantity:{order.Quantity} Date:{order.OrderDate}");
            }
        }


    }
}
