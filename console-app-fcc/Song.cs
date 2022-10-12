using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_fcc
{
    class Song
    {
        public string title;
        public string artist;
        public double duration;
        // adding static attribute to the class, means it has the same value across all other objects created
        public static int songCount = 0;

        public Song(string Title, string Artist, double Duration)
        {
            title = Title;
            artist = Artist;
            duration = Duration;
            songCount++;
        }

        // Create a custom getter method to access static attribute using objects
        public int GetSongCount()
        {
            return songCount;
        }
    }
}
