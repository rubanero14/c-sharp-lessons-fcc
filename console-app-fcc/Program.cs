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
            string color, pluralNoun, celebrity;

            // Entering color by user
            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            // Entering pluralNoun by user
            Console.Write("Enter plural noun: ");
            pluralNoun = Console.ReadLine();

            // Entering celebrity by user
            Console.Write("Enter celebrity name: ");
            celebrity = Console.ReadLine();

            // MadLibs
            Console.WriteLine("Roses are {0}", color);
            Console.WriteLine("{0}s are blue", pluralNoun);
            Console.WriteLine("I Love {0}", celebrity);

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
