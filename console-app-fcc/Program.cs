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
            int addition = 1 + 3;
            int modulus = 3 % 2;
            decimal division = 5 / 2.0m;
            const double Power = 2.3;

            // Working with numbers
            Console.WriteLine("{0} => Addition", addition);
            addition++;
            Console.WriteLine("{0} => Addition ++", addition);
            Console.WriteLine("{0} => Modulus", modulus);
            Console.WriteLine("{0} => Division of 2 number and converting the answer into float", division);

            // Order of operations
            Console.WriteLine("{0} => 4 + 2 * 3 yields 10 where multiplication is done first", 4 + 2 * 3);
            Console.WriteLine("{0} => (4 + 2) * 3 yields 18 where operation inside parentheses is done first", (4 + 2) * 3);

            // If 2 ints added, it returns ints, if an int is added to a float, decimal or double, it returns either a float, decimal or double. This is another way of converting int to float, decimal or double type

            // Math. methods
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Max(1, 10));
            Console.WriteLine(Math.Min(1, 10));
            Console.WriteLine(Math.Round(4.6));

            // Pause the console without closing
            Console.ReadLine();
        }
    }
}
