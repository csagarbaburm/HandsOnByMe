namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        //a
        {
            string str = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine(str[12]);


            //b

            int res = str.IndexOf("is");

            if (res >= 0)
            {

                Console.WriteLine($"is is available at position: {res} ");
            }
            else
            {
                Console.WriteLine("'is' is not available...");
            }

            //c
            {
                str = str + " and killed it";

                Console.WriteLine(str);
            }
            //d
            {
                str = str + " and killed it";

                string[] strs = str.Split(" ");

                if (strs[strs.Length - 1] == "dogs")
                {
                    Console.WriteLine("The sting ends with word 'dogs'");
                }

                else
                {
                    Console.WriteLine("The string does not ends with word 'dogs'");
                }
            }
                //e

                
                    {
                        string str1 = "The quick brown fox jumps over the lazy dog";


                        string str2 = "The quick brown Fox jumps over the lazy Dog";


                        if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Both stings are equal..");
                        }

                        else
                        {
                            Console.WriteLine("Both strings are different.");
                        }

                    }
            //f
            {
                string str1 = "The quick brown fox jumps over the lazy dog";

               

                string str2 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";


                if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Both stings are equal..");
                }

                else
                {
                    Console.WriteLine("Both strings are different.");
                }

            }
            //g
            {
                string str1 = "The quick brown fox jumps over the lazy dog";

               

                Console.WriteLine($"Length of string is: {str1.Length}");


            }
            //h
            {
                string str1 = "The quick brown fox jumps over the lazy dog";

               

                string str2 = "The quick brown Fox jumps over the lazy Dog";


                if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Both stings are equal..");
                }

                else
                {
                    Console.WriteLine("Both strings are different.");
                }
            }
            //i
            {
                string str1 = "The quick brown fox jumps over the lazy dog";
                str1 = str1.Replace("The", "A");
                Console.WriteLine(str1);
            }
            //j
            {
                string str1 = "The quick brown fox jumps over the lazy dog";

                string[] strs = str1.Split("jumps");

                strs[0] = strs[0] + "jumps";

                Console.WriteLine(strs[0]);
                Console.WriteLine(strs[1]);


            }
            //k
            {
                string str1 = "The quick brown fox jumps over the lazy dog";

                string[] strs = str1.Split("jumps");

                strs[1] = "jumps" + strs[1];

                Console.WriteLine(strs[0].Remove(0, strs[0].IndexOf("fox")));
                Console.WriteLine(strs[1].Remove(0, strs[1].IndexOf("dog")));


            }
            //l
            {
                string str1 = "The quick brown fox jumps over the lazy dog";

                string[] strs = str1.Split("jumps");

                strs[1] = "jumps" + strs[1];

                Console.WriteLine(strs[0].ToLower());
                Console.WriteLine(strs[1].ToLower());

            }
            //m
            {

                string str1 = "The quick brown fox jumps over the lazy dog";

                string[] strs = str1.Split("jumps");

                strs[1] = "jumps" + strs[1];

                Console.WriteLine(strs[0].ToUpper());
                Console.WriteLine(strs[1].ToUpper());



                //n)
                Console.WriteLine();


                if (str1.IndexOf('a') > -1)
                {
                    Console.WriteLine($"'a' is found at position:{str1.IndexOf('a')}");
                }
                else
                {
                    Console.Write($"'a' is not found");
                }


                //o)
                Console.WriteLine();

                if (str1.LastIndexOf('e') > -1)
                {
                    Console.WriteLine($"'e' is found at position:{str1.LastIndexOf('e')}");
                }
                else
                {
                    Console.Write($"'e' is not found");
                }


                //p)

                Console.WriteLine();
                Console.Write("Enter the home directory path: ");

                string usrPath = Console.ReadLine();

                usrPath = usrPath + @"/WebApps/MyApps/Images";

                Console.WriteLine("The Path is: " + usrPath);


                //q)
                Console.WriteLine();
                string poem = "I WANDER'D lonely as a cloud\r\nThat floats on high o'er vales and hills, \r\nWhen all at once I saw a crowd,\r\nA host, of golden daffodils;Beside the lake, beneath the trees,\r\nFluttering and dancing in the breeze.\r\n";

                Console.Write(poem);
            }







        }
    }
}
    
