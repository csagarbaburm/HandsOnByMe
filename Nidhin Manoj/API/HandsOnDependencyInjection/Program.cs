namespace HandsOnDependencyInjection
{
    class Student
    {
        public int Id;
        public string Name;
        public Student(int id,string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Register
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
