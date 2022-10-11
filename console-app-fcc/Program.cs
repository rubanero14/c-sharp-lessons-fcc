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
            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber);

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }

        // Creating new method, static keyword used to invoke a method that returns something, keyword double is to maintain return double value type, followed by the method name with Cap letter on each word
        static int Cube(int measurement) {
            return measurement * measurement * measurement;
        }
    }
}
