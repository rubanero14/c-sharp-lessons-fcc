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
            // to create array variable first declare type followed by [] to signify this is array variable contains number values, followed by the array name
            // on the right hand side ofthe expression, contrary to JavaScript convention for array container '[]', C# uses {} as array
            int[] luckyNumbers = { 1, 3, 6, 9, 12 };
            string[] friends = new string[2];

            friends[0] = "Lalitha";
            friends[1] = "Sham";

            luckyNumbers[2] = 4;

            Console.WriteLine(luckyNumbers[2]);
            Console.WriteLine(friends);

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
