namespace HandsOnGenericCollections
{
    class Sample<T>
    {
        public T a;
        public T b;
        public void Details(T i,T j)
        {
            a = i;
            b = j;
            Console.WriteLine($"a={0} and b={1}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample<int> sample = new Sample<int>();
            sample.a = 10;
            sample.b = 20;
            sample.Details(3,8);
            Sample<char> ob1 = new Sample<char>();
            ob1.a = 'a';
            ob1.b = 'i';
            ob1.Details('r', 't');
            Sample<string> ob2 = new Sample<string>();
                ob2.Details("rahul","dravid");

        }
    }
}
