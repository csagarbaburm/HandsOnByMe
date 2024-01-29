using System.Collections;

namespace HandsOnNonGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = "david";
            var c = 'c';
            ArrayList obj = new ArrayList();
            obj.Add(12);
            obj.Add("david");
            obj.Add('a');
            obj.Add(true);
            obj.Insert(2, 12.34);
            Console.WriteLine("size: " + obj.Count);
            char ch = (char)obj[3];
            int m = (int)obj[0];
            obj.Remove("david");
            Console.WriteLine("size: " + obj.Count);
            foreach (object k in obj) 
            Console.WriteLine(k);
            Console.WriteLine();
            foreach (var k in obj)
                Console.WriteLine(k);
            Console.WriteLine();
         
        }
    }
}

