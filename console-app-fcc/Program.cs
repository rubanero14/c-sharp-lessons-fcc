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
            // Defining the new books properties by passing as arguements
            Book book1 = new Book("Harry Potter", "J.K. Rowling", 400);

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine();

            Book book2 = new Book("Lord of the Rings", "J.R.R. Tolkien", 700);

            // Overwriting the existing title attribute of the book2 object
            book2.title = "The Hobbit";

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            // Creating a new book3 object without any arguements passing into it
            Book book3 = new Book();

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
