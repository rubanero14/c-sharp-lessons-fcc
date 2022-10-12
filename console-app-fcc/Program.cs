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
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            // accessing the static attribute of the class
            Console.WriteLine(Song.songCount);

            Song cholaChola = new Song("Chola Chola", "A.R. Rahman", 200);

            // accessing the static attribute of the class using type/class
            Console.WriteLine(Song.songCount);

            // accessing the static attribute of the class using object
            Console.WriteLine(kashmir.GetSongCount());

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
