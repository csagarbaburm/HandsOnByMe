namespace HandsOnClassTypes
{
    static class Convertor
    {
        public static int a;
        public static double RTD(double rupees)
        {
            return rupees / 78.5;
        }
        public static double DTR(double dollers)
        {
            return dollers * 78.5;
        }
    }
    internal class StaticClass
    {
       static void Main(string[] args)
        {
            Console.WriteLine("{0:C}",Convertor.RTD(100000));
            Console.WriteLine(Convertor.DTR(1000));
        }
    }
}
