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
            // try catch block used to handle exceptions/errors
            // try block is used to run risky codes that might throw an exception or errors
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);  
            }
            // catch block is fired when an error is encountered by running try block
            // Catching All Exceptions
            /*
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            */
            // Catching Specific Exception
            catch (DivideByZeroException e) // Exception keyword handles all exceptions, DivideByZeroException only handles divide by zero errors
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (FormatException e) // FormatException only handles errors made by type or operations based errors, ie: dividing number using chars
            {
                Console.WriteLine("Error: " + e.Message);
            }
            // finally block is fired no matter if an exception thrown or not
            finally
            {
                Console.WriteLine("This fires all the time whenever a try block or catch block code are run!");
            }
            
            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
