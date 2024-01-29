namespace HandsOnExceptionHandling
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a,b values");
                byte a = byte.Parse(Console.ReadLine());
                byte b = byte.Parse(Console.ReadLine());
                if (b == 0)
                {
                    throw new DivideByZeroException("b value should not be zero");
                }
                else
                {
                    int c = a / b;
                    Console.WriteLine(c);
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }   
            
        }
    }
}
