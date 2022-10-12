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
            // Adding , inside of type array declaration, signifies that this variable is 2 dimensional array
            // for more dimension, just add more ,
            // Example for 3D array, int[,,] is used to declared
            int[,] numberGrid = {
                {1, 2}, 
                {3, 4}, 
                {5, 6},
            };

            // for unknown values in the array, we initialize the array as below, where 3 signifies number of rows and 2 signifies number of columns inside each rows
            /*
               equivalent to int[,] myArray = {
                    {A, B}, 
                    {C, D}, 
                    {E, F}
               }; 
             */
            int[,] myArray = new int[3,2];

            Console.WriteLine(numberGrid[1, 1]);

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
