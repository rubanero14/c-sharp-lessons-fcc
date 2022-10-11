﻿using System;
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
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are tall male!");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are short male!");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are tall female!");
            } else
            {
                Console.WriteLine("You are short female!");
            }

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
