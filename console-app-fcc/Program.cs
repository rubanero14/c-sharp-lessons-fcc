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
            // Logging output to the console
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            Console.WriteLine("");

            string characterName = "Raj";
            int characterAge = 36;

            // Dynamic Data interpolation - Concatenation method
            Console.WriteLine("There once a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            // Dynamic Data interpolation - Placeholder method
            Console.WriteLine("He really like the name {0}", characterName);
            Console.WriteLine("He didnt like being {0}", characterAge);

            // Pause the console without closing
            Console.ReadLine();
        }
    }
}
