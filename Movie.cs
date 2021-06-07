using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieList_Lab_10
{

    public enum Genre
    {
        [Description("1 - Horror")]
        Horror = 1,
        Comedy,
        Romance,
        Action,
        Biograhy,
        ComedyDrama,
        Drama,
        Thriller

    }


    class Movie
    {
        public string Title { get; set; }
        public int Runtime { get; set; }

        public Genre genre { get; set; }

        public Movie(string title, int runtime, Genre genre)
        {
            Title = title;
            Runtime = runtime;
            this.genre = genre;
        }

        internal bool OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
