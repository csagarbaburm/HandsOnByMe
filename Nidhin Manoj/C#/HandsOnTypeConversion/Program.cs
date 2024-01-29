using System.Globalization;

namespace HandsOnTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte b = 34;
            //int k = b;
            //double d = b;
            //short s = b;
            //s = 345;
            //k = s;
            //d = s;
            //k = 4567;
            //d = k;
            //long l = 456;

            ////convert decimal value to int,byte,short,long,double
            //decimal dd = 45;
            //int t = (int)dd;
            //byte bb=(byte)t;
            //short ss= (short)bb;
            //long ll= (long)ss;
            //double r= (double)ll;

            //covert values from reference type to value type
            //string s = "322";
            //int k = int.Parse(s);
            //byte b= byte.Parse(s);
            //double d = double.Parse(s);
            //short sh= short.Parse(s);
            //long l = long.Parse(s);
            ////convert values from value type to string
            //int k1 = 34;
            //string s1= k1.ToString();
            //double d1 = 34.87;
            //s1=s1.ToString();

            //convert value type to object(boxing)
            int k = 45;
            double d = 34.90;
            decimal dd = 45.8738m;
            //implict conversion
            object o1 = k;
            object o2 = d;
            object o3 = dd;
            //convert object to value datatype is unboxing
            object o4 = 34;
            int n = (int)o4;
            o4 = 57.84;
            double o5=(double)o4;
            Console.WriteLine(05);
            Console.WriteLine(n);
            //convert one type to another
            //using convert class
            double ddd = 12.34;
            int kk=Convert.ToInt32(ddd);
            k = Convert.ToInt32("123");
            object o = 23;
            k = Convert.ToInt32(o);
            double dt=Convert.ToDouble("34556");
            o = 45.98;
            dt = Convert.ToDouble(o);
            Console.WriteLine(dt);
            Console.WriteLine(o);
        }
    }
}
