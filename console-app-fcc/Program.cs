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
            Student student1 = new Student("Sri", "Computer Science", 4.00m);
            Student student2 = new Student("Sharm", "Business", 3.95m);
            Student student3 = new Student("Raj", "Business", 3.45m);

            Console.WriteLine(student1.hasHonors());
            Console.WriteLine(student2.hasHonors());
            Console.WriteLine(student3.hasHonors());

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
