using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_fcc
{
    class Movie
    {
        // public is accessible by anyone from any program or classes
        // private can be only accessible within the class Movie itself
        public string title;
        public string director;
        private string rating;

        public Movie(string Title, string Director, string rating)
        {
            title = Title;
            director = Director;
            Rating = rating; // setting attribute as Rating (getter and setter name for rating) to invoke the Setter method
        }

        // Getters and Setters is used to secure the class and its data flows in and out the attributes - Security purpose
        // Declaring Getters and Setters for rating
        public string Rating
        {
            get { return rating; }
            set {
                string[] ratingList = { "G", "PG", "PG-13", "NR", "R" };

                if (ratingList.Contains(value))
                {
                    rating = value;
                } 
                else
                {
                    rating = ratingList[3]; // Setting as NR if value inputted differs than the values inside ratingList
                }
            }
        }
    }
}
