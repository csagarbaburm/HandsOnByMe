namespace CodeChallenge
{
    internal class Student
    {
        public int Id;
        public string Name;
        public byte Age;
        public byte Std;
        public char Section;

    }
    class StudentRepository
    {
        public Student[] students = new Student[20];
        public int idx = 0;
        public void AddStudent(Student student)
        {
            if (idx <= students.Length)
            {
                students[idx] = student;
                idx++;
               
            }
            else
            {
                Console.WriteLine("class is full");
            }

        }
        public void UpdateDetails()
        {
       try

            {

                Console.WriteLine("What do you wish to Update:\n1.Name\n2.Age\nEnter your choice(1/2):");

                int ch = int.Parse(Console.ReadLine());


                switch (ch)

                {

                    case 1:

                        {

                            Console.Write("Enter ID of the Student:");

                            int n = int.Parse(Console.ReadLine());

                            Console.Write("Enter new name of the Student:");

                            string newName = Console.ReadLine();

                            bool flag = false;

                            foreach (Student student1 in students)

                            {

                                if (student1 != null)

                                {

                                    if (student1.Id == n)

                                    {

                                        flag = true;

                                        student1.Name = newName;

                                    }

                                }


                            }

                            if (flag == false)

                                Console.WriteLine("\nStudent not found....");

                            break;

                        }

                    case 2:

                        {

                            Console.Write("Enter ID of the Student:");

                            int n = int.Parse(Console.ReadLine());

                            Console.Write("Enter new age of the Student:");

                            byte newAge = byte.Parse(Console.ReadLine());

                            bool flag = false;

                            foreach (Student student1 in students)

                            {

                                if (student1 != null)

                                {

                                    if (student1.Id == n)

                                    {

                                        flag = true;

                                        student1.Age = newAge;

                                    }

                                }


                            }

                            if (flag == false)

                                Console.WriteLine("\nStudent not found....");

                            break;

                        }

                    default:

                        Console.WriteLine("Invalid Choice!!!");

                        break;

                }

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }
        }
            public Student[] GetStudentByName(string name)
        {
            Student[] student_name = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.Name == name)
                    {
                        student_name[idx] = student;
                        idx++;
                    }
                }
            }
            return student_name;
        }
        public Student[] GetStudentById(int id)
        {
            Student[] student_id = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.Id == id)
                    {
                        student_id[idx] = student;
                        idx++;
                    }
                }
            }
            return student_id;
        }
        public Student[] GetStudentByStd(byte std)
        {
            Student[] student_std = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.Std == std)
                    {
                        student_std[idx] = student;
                        idx++;
                    }
                }
            }
            return student_std;
        }

        public Student[] GetStudentByAge(int age)
        {
            Student[] student_age = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.Age == age)
                    {
                        student_age[idx] = student;
                        idx++;
                    }
                }
            }
            return student_age;
        }
        public Student[] GetStudentBySection(char section)
        {
            Student[] student_section = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.Section == section)
                    {
                        student_section[idx] = student;
                        idx++;
                    }
                }
            }
            return student_section;
        }

        public Student[] GetAllStudent()
        {
            return students;
        }
        
    }

    class Test_Student
    {
        static void Main(string[] args)
        {
            StudentRepository studentRepository = new StudentRepository();

            do
            {
                Console.WriteLine("1.Create Student");
                Console.WriteLine("2.Update user details");
                Console.WriteLine("3.Display Student details based on ID");
                Console.WriteLine("4.Display Student details based on Name");
                Console.WriteLine("5.Display Student details based on std");
                Console.WriteLine("6.Display Student details based on std and section");
                Console.WriteLine("7.Display Student details based on age");
                Console.WriteLine("8.Display all Student details");
                Console.WriteLine("9.exit");
                Console.WriteLine("enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Student student = new Student();
                            Console.WriteLine("Enter the id:");
                            student.Id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            student.Name = Console.ReadLine();
                            Console.WriteLine("Enter age:");
                            student.Age = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the std:");
                            student.Std = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the section:");
                            student.Section = char.Parse(Console.ReadLine());
                            studentRepository.AddStudent(student);
                        }
                        break;
                        case 2:
                        {
                            studentRepository.UpdateDetails();

                        }
                            
                            break;
                    
                    case 3:
                        {
                            Console.WriteLine("Enter the ID:");
                            int Id = int.Parse(Console.ReadLine());
                            Student[] student = studentRepository.GetStudentById(Id);
                            foreach (Student students in student)
                            {
                                if (students != null)
                                {
                                    Console.WriteLine($"Id:{students.Id} Name:{students.Name} age:{students.Age} std:{students.Std} section:{students.Section}");
                                }
                              
                            }
                            Console.WriteLine();

                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter the Name:");
                            string Name = Console.ReadLine();
                            Student[] student = studentRepository.GetStudentByName(Name);
                            foreach (Student students in student)
                            {
                                if (students != null)
                                {
                                    Console.WriteLine($"Id:{students.Id} Name:{students.Name} age:{students.Age} std:{students.Std} section:{students.Section}");
                                }
                               
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter the std:");
                            byte std =byte.Parse(Console.ReadLine());
                            Student[] student = studentRepository.GetStudentByStd(std);
                            foreach (Student students in student)
                            {
                                if (students != null)
                                {
                                    Console.WriteLine($"Id:{students.Id} Name:{students.Name} age:{students.Age} std:{students.Std} section:{students.Section}");
                                }
                               
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Enter the section:");
                            char section = char.Parse(Console.ReadLine());
                            Student[] student = studentRepository.GetStudentBySection(section);
                            foreach (Student students in student)
                            {
                                if (students != null)
                                {
                                    Console.WriteLine($"Id:{students.Id} Name:{students.Name} age:{students.Age} std:{students.Std} section:{students.Section}");
                                }
                               
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Enter the age:");
                            byte age = byte.Parse(Console.ReadLine());
                            Student[] student = studentRepository.GetStudentByAge(age);
                            foreach (Student students in student)
                            {
                                if (students != null)
                                {
                                    Console.WriteLine($"Id:{students.Id} Name:{students.Name} age:{students.Age} std:{students.Std} section:{students.Section}");
                                }
                               
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 8:
                        {

                            Student[] student = studentRepository.GetAllStudent();
                            foreach (Student students in student)
                            {
                                if (students != null)
                                {
                                    Console.WriteLine($"Id:{students.Id} Name:{students.Name} age:{students.Age} std:{students.Std} section:{students.Section}");
                                }
                                
                            }
                            Console.WriteLine();

                        }
                        break;
                    case 9:
                        {
                            Environment.Exit(0);
                        }
                        break;
                      }

            } while (true);

        }
    }
} 
