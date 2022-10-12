using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_fcc
{
    // A Class is a custom and complex data type created representing a real world object or data structure
    // Traditionally class are named using capital letter followed by small cases in each word
    class Book
    {
        // declaring attributes of a class
        public string title;
        public string author;
        public int pages;

        // Creating another constructor without any arguements passed into it, for manual attribute declaration
        public Book()
        {

        }

        // Constructor method for this class, the name of the constructor follow class name it serves
        // Attributes for this class are dynamically assigned inside the constructor method by passing the values as arguements into the method
        public Book(string Title, string Author, int Pages)
        {
            title = Title;
            author = Author;
            pages = Pages;
        }
    }
}
