
namespace Assignment5

{

    interface GovtRules

    {
        public double EmployeePF(double basicSalary);

        public string LeaveDetails();

        public double GratuityAmount(float serviceCompleted, double basicSalary);

    }


    public class TCS : GovtRules

    {

        int empid;

        string name;

        string dept;

        string desg;

        double basicSalary;

        int yrs;

        public TCS(int empid, string name, string dept, string desg, double basicSalary, int yrs)

        {

            this.empid = empid;

            this.name = name;

            this.dept = dept;

            this.desg = desg;

            this.basicSalary = basicSalary;

            this.yrs = yrs;

        }

        public int EmpID

        {

            get { return empid; }

        }

        public string Name

        {

            get { return name; }

        }

        public string Dept

        {

            get { return dept; }

        }

        public double BasicSalary

        {

            get { return basicSalary; }

        }

        public string Desg

        {

            get { return desg; }

        }

        public double EmployeePF(double basicSalary)

        {

            double pf;

            pf = (12 / 100) * basicSalary + (8.33 / 100) * basicSalary + (3.67 / 100) * basicSalary;

            return pf;


        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)

        {

            double graAmount;

            if (serviceCompleted > 10)

                graAmount = 2 * basicSalary;

            else if (serviceCompleted > 20)

                graAmount = 3 * basicSalary;

            else graAmount = 0.0;

            return graAmount;

        }

        public string LeaveDetails()

        {

            string lvDetails = "Casual Leave per month: 1\nSick Leave per year: 12\nPrevilage Leave per year: 10";

            return lvDetails;

        }


        public void DisplayTCS()

        {

            Console.WriteLine("=========================================================");

            Console.WriteLine($"EmpID: {EmpID}");

            Console.WriteLine();

            Console.WriteLine($"Emp Name: {Name}");

            Console.WriteLine();

            Console.WriteLine($"Department: {Dept}");

            Console.WriteLine();

            Console.WriteLine($"Designation: {Desg}");

            Console.WriteLine();

            Console.WriteLine($"Basic Salary: {BasicSalary}");

            Console.WriteLine();

            Console.WriteLine($"Employee PF: {EmployeePF(BasicSalary)}");

            Console.WriteLine();

            Console.WriteLine($"Leave Details: \n{LeaveDetails()}");

            Console.WriteLine();

            Console.WriteLine($"Gratuity Amount: {GratuityAmount(yrs, basicSalary)}");

            Console.WriteLine();

            Console.WriteLine("=========================================================");

        }



    }


    public class Accenture : GovtRules

    {

        int empid;

        string name;

        string dept;

        string desg;

        double basicSalary;


        public Accenture(int empid, string name, string dept, string desg, double basicSalary)

        {

            this.empid = empid;

            this.name = name;

            this.dept = dept;

            this.desg = desg;

            this.basicSalary = basicSalary;

        }

        public int EmpID

        {

            get { return empid; }

        }

        public string Name

        {

            get { return name; }

        }

        public string Dept

        {

            get { return dept; }

        }

        public double BasicSalary

        {

            get { return basicSalary; }

        }

        public string Desg

        {

            get { return desg; }

        }

        public double EmployeePF(double basicSalary)

        {

            double pf;

            pf = (12 / 100) * basicSalary + (12 / 100) * basicSalary;

            return pf;


        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)

        {

            return 0.0;

        }

        public string LeaveDetails()

        {

            string lvDetails = "Casual Leave per month: 2\nSick Leave per year: 5\nPrevilage Leave per year: 5";

            return lvDetails;

        }


        public void DisplayAccenture()

        {

            Console.WriteLine("=========================================================");

            Console.WriteLine($"EmpID: {EmpID}");

            Console.WriteLine();

            Console.WriteLine($"Emp Name: {Name}");

            Console.WriteLine();

            Console.WriteLine($"Department: {Dept}");

            Console.WriteLine();

            Console.WriteLine($"Designation: {Desg}");

            Console.WriteLine();

            Console.WriteLine($"Basic Salary: {BasicSalary}");

            Console.WriteLine();

            Console.WriteLine($"Employee PF: {EmployeePF(BasicSalary)}");

            Console.WriteLine();

            Console.WriteLine($"Leave Details: \n{LeaveDetails()}");

            Console.WriteLine();

            Console.WriteLine("=========================================================");

        }



    }


    public class Test_Main

    {

        static void Main()

        {

            while (true)

            {

                Console.WriteLine("Choose your Company:\n1. TCS \n2. Accenture \n3. EXIT \n(Enter 1/2/3)");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)

                {

                    case 1:

                        GetTCSData();

                        break;

                    case 2:

                        GetAccentureData();

                        break;

                    case 3:

                        Environment.Exit(0);

                        break;

                }

            }


            //TCS tc = new TCS(123, "A", "Software", "development", 20000.0);

            //Console.WriteLine(tc.GratuityAmount(16,20000.0));

        }


        public static void GetTCSData()

        {


            Console.Write("Employee ID: ");

            int id = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");

            string name = Console.ReadLine();

            Console.Write("Department: ");

            string dept = Console.ReadLine();

            Console.Write("Designation: ");

            string desg = Console.ReadLine();

            Console.Write("Basic Salary: ");

            double basicSalary = double.Parse(Console.ReadLine());

            Console.Write("Years of service: ");

            int yrs = int.Parse(Console.ReadLine());

            TCS tcs = new TCS(id, name, desg, dept, basicSalary, yrs);

            tcs.DisplayTCS();


        }

        public static void GetAccentureData()

        {


            Console.Write("Employee ID: ");

            int id = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");

            string name = Console.ReadLine();

            Console.Write("Department: ");

            string dept = Console.ReadLine();

            Console.Write("Designation: ");

            string desg = Console.ReadLine();

            Console.Write("Basic Salary: ");

            double basicSalary = double.Parse(Console.ReadLine());

            Accenture acc = new Accenture(id, name, desg, dept, basicSalary);

            acc.DisplayAccenture();


        }

    }


}

