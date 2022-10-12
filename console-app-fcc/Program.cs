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
            // Initiate GetDay fn here
            Console.WriteLine(GetDay(7));

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum) 
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            };

            return dayName;
        }
    }
}
