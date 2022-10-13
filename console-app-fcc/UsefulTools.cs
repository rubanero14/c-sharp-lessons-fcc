using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_fcc
{
    // adding static modifier to disable user from creating new object if this class, only accessible via calling static method only
    static class UsefulTools
    {
        // Creating a static method
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }
    }
}
