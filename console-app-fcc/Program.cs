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
            Movie bahubali = new Movie("Bahubali: The Beginning", "Joss Whedon", "PG-13");
            Movie ps1 = new Movie("Ponniyin Selvan - Chapter 1", "Maniratnam", "PG");

            Console.WriteLine(bahubali.Rating);
            Console.WriteLine(ps1.Rating);

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
