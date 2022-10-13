using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_fcc
{
    // to inherit attributes of another class or superclass to this subclass, under the class name append ':' followed by the superclass name, it is similar to JS extends keyword
    class ItalianChef : Chef
    {
        public void MakePizza()
        {
            Console.WriteLine("The Chef makes pizza!");
        }

        // Adding override keyword to method declaration, means it can override the superclass method that has virtual keyword with same method name 
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes fettucini!");
        }
    }
}
