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
            int[] oddNumbers = {1, 3, 6, 9, 12, 15, 18, 21};
            for (int i = 0; i < oddNumbers.Length; i++)
            {
                Console.WriteLine(oddNumbers[i]);
            }

            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine(j);
            }

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
