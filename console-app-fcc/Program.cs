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
            // Calling here the method constructed below the function Main
            // Whenever code is compiled and executed, the system only runs any code stated within Main method
            SayHi();
            SayHi();
            SayHi();

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }

        // Creating new method, static keyword used to invoke a method that returns something, keyword void is to maintain return 'nothing', followed by the method name with Cap letter on each word
        static void SayHi(/*string name*/) {
            Console.Write("Insert your name here: ");
            string name = Console.ReadLine();
            Console.Write("Insert your age here: ");
            string age = Console.ReadLine();

            Console.WriteLine("Hello {0} and your age is {1}!", name, age);
        }
    }
}
