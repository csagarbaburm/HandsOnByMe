namespace HandsOnConditionalAndIterativeStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //simple-if


            Console.WriteLine("enter the name");
            string name=Console.ReadLine();
            Console.WriteLine("enter the age");
            int age = int.Parse(Console.ReadLine());
            if(age>=12)
            {
                Console.WriteLine($"{name} you are allow to write the exam");
            }
            else
            {
                Console.WriteLine($"{name} you are only " +$"{age},So not allowed to write the exam");
            }
            Console.WriteLine("Thank You!!");
        }
    }
}
