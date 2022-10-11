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
            // Convert string to number
            int num = Convert.ToInt32("32");
            Console.WriteLine(num + 6);

            // Perform user input and convert to number type and store it, finally display
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
