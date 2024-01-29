namespace HandsOnInterfaces
{
    public interface IBank
    {
        void OpenAccount();
        void TransferFUnd();
        void ApplyLoan();
        void ApplyCreditCard();

    }
    class SBI:IBank
    {
        public void OpenAccount()
        {

        }
        public void TransferFUnd()
        {

        }
         
        public void ApplyLoan() 
        {

        }
        public void ApplyCreditCard()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
