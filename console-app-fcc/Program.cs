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
            // Console.ReadLine() acts as prompt that watches and reads for user input
            // Console.Write() displays on the same line
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Hello {0} and you are {1} years old!", name, age);

            // Pause the console without closing
            Console.ReadLine();
        }
    }
}
