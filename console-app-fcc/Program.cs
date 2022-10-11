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
            string phrase = "Learn C#" + " is Cool!";

            // Working with strings
            Console.WriteLine("{0} \n \" Hi There", phrase);
            Console.WriteLine("{0} to check length of string use .Length()", phrase.Length);
            Console.WriteLine("{0} => To Upper Case \n{1} => To Lower Case", phrase.ToUpper(), phrase.ToLower());
            Console.WriteLine("{0} => Contains C# substring \n{1} => Contains CSharp substring", phrase.Contains("C#"), phrase.Contains("CSharp"));
            Console.WriteLine("{0} => first char in string \n{1} => middle char in string \n{2} => last char in string", phrase[0], phrase[((phrase.Length - 1)/2)], phrase[phrase.Length - 1]);
            Console.WriteLine("{0} => finding if a char exist and its position \n{1} If a char or string dont exist returns -1", phrase.IndexOf("earn"), phrase.IndexOf("xavier"));
            Console.WriteLine("{0} {1} => .Substring accepts index and returns the char or word from the position stated and second arguement is to extract and show how many chars",
                phrase.Substring(phrase.IndexOf("C#"), 4), phrase.IndexOf("C#"));

            // Pause the console without closing
            Console.ReadLine();
        }
    }
}
