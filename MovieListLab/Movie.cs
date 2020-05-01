using System;
using System.Collections.Generic;
using System.Text;

namespace MovieListLab
{
    class Movie
    {

        private string title;
        private string genre;


        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        public Movie()
        {
            title = "Movie";
            genre = "Genre";
        }

        public Movie (string _title, string _genre)
        {
            title = _title;
            genre = _genre;
        }



    
    }
}
