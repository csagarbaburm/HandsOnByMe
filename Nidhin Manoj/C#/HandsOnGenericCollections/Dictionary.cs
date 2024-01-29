using HandsOnGenericCollection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Dictionary
    {
        static void Main()

        {
            SortedDictionary<int,string> obj= new SortedDictionary<int, string>();
            obj.Add(40934, "hihak");
            obj.Add(35446, "rahul");
            obj.Add(43657, "jacob");
            obj.Add(32542, "tambi");
            string name = obj[43657];
            Console.WriteLine(name);
            foreach(var key in obj.Keys)
            {
                Console.WriteLine($"{key} name:{obj[key]}");
            }
            Teacher t1 = new Teacher()
            {
                Id=335, Name="hihak",Email= "geroge@gmail.com",
                Mobile = "909090909",
                School = "DPS"
            };
            Teacher t2 = new Teacher() { Id = 897, Name = "rahul", Email = "rahul@gmail.com", Mobile = "909090989", School = "DPS" };
            Teacher t3 = new Teacher() { Id = 786, Name = "jacob", Email = "jacob@gmail.com", Mobile = "909090989", School = "KPH" };

            Dictionary<int, Teacher> ob1 = new Dictionary<int, Teacher>();
            ob1.Add(t1.Id, t1);
            ob1.Add(t2.Id, t2);
            ob1.Add(t3.Id, t3);
            Teacher t = ob1[t1.Id];
            Console.WriteLine($"Name: {t.Name} Email: {t.Email}");
           
            }
        }
    }
