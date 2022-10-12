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
            // Creating a new object using Book class, a new instance of a Book class
            // Notice the type declared is type of Book which is custom data type declared in the Book Class, followed by the variable name and storing the new Book() object in it
            Book book1 = new Book();
            // Defining the new books properties by storing new values into each attributes
            book1.title = "Harry Potter";
            book1.author = "J.K. Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine();

            Book book2 = new Book();
            // Defining the new books properties by storing new values into each attributes
            book2.title = "Lord of the Rings";
            book2.author = "J.R.R. Tolkien";
            book2.pages = 700;

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
