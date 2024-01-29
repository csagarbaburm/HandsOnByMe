using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalAndIterativeStatements
{
    internal class IfElseIF
    {
        static void Main()
        {

            byte m1 =75 , m2 = 85 , m3 = 35, m4 = 55, m5 = 59,m6 = 57;
            int total = (m1 + m2 + m3 + m4 + m5 + m6);
            float avg = total / 6;
            string grade= null;
            if(avg>=70)
            {
                grade = "first class";
            }
            else if(avg>60 && avg<69)
            {
                grade = "second class";
            }
            else if(avg>50 && avg<59)
            {
                grade = "third class";
            }
            else
            {
                grade = "fail";
            }
            if(grade=="fail")
            {
                Console.WriteLine("sorry, You are failed");
            }
            else
            {
                Console.WriteLine($"result: {grade} total marks: {total} percentage: {avg}%");
            }
        }
    }
}
