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
            // Building Exponent function
            Console.WriteLine(GetPower(4,3));

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }

        static double GetPower(int baseNum, int powerNum)
        {
            double result = baseNum;

            for (int i = 1; i < powerNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}
