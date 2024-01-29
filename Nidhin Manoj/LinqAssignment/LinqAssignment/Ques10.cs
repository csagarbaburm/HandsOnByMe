using LInqAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqAssignment
{
    public class ItemxQuantity
    {
        public string name { get; set; }
        public int Totalquantity { get; set; }
    }

    internal class Ques10
    {
        public static void Main(string[] args)
        {
            List<Order> orderlist = new List<Order>()
            {
                new Order {OrderId=101,ItemName="A",Quantity=100,OrderDate=new DateTime(2023,1,30),},
                new Order {OrderId=102,ItemName="B",Quantity=2100,OrderDate=new DateTime(2023,2,15),},
                new Order {OrderId=103,ItemName="C",Quantity=10,OrderDate=new DateTime(2023,3,30),},
                new Order {OrderId=104,ItemName="D",Quantity=95,OrderDate=new DateTime(2023,4,30),},
                new Order {OrderId=105,ItemName="A",Quantity=500,OrderDate=new DateTime(2023,5,30),},
                new Order {OrderId=106,ItemName="F",Quantity=9,OrderDate=new DateTime(2023,1,30),},
                new Order {OrderId=107,ItemName="G",Quantity=1410,OrderDate=new DateTime(2023,12,30),},
                new Order {OrderId=107,ItemName="C",Quantity=2320,OrderDate=new DateTime(2023,1,30),},
                new Order {OrderId=108,ItemName="D",Quantity=10,OrderDate=new DateTime(2023,1,30),},
                new Order {OrderId=108,ItemName="H",Quantity=20,OrderDate=new DateTime(2023,1,30),},
                new Order {OrderId=108,ItemName="C",Quantity=2,OrderDate=new DateTime(2023,1,30),},


            };
            

            int objs = (orderlist.Where(ord => ord.Quantity == 0)).Count();

            if (objs <= 0)
            {
                Console.WriteLine("No orders below 0");
            }



            var result = (from item in orderlist
                          group item by item.ItemName into groupedList
                          let totQTY = groupedList.Sum(qty => qty.Quantity)
                          orderby totQTY descending
                          select new { op1 = totQTY, name = groupedList.Key }).FirstOrDefault();



            Console.WriteLine("The item that has overall maximum orders: " + result.name + " qty :" + result.op1);

        }
    }
}
