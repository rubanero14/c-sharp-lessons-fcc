using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_fcc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Learning different data types
            string phrase = "Hello";
            char grade = 'A';
            int age = 36;
            double gpa = 4.0;
            bool isMale = true;

            Console.WriteLine("{0} {1} {2} {3} {4}", phrase, grade, age, gpa, isMale);

            // Pause the console without closing
            Console.ReadLine();
        }
    }
}
