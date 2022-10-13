using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_fcc
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken!");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad!");
        }

        // Adding virtual keyword in a method, means this method can be overridden in any subclasses
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs!");
        }
    }
}
