using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieList_Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make movie class
            //Create Genre Enum 
            //Allow user to search by genre

            List<Movie> movies = new List<Movie>();

            Movie m1 = new Movie("Goodfellas", 180, Genre.Action);

            movies.Add(m1);

            Movie m2 = new Movie("GodFather",178 , Genre.Action);
            movies.Add(m2);

            Movie m3 = new Movie("Good Will Hunting", 180, Genre.Romance);
            movies.Add(m3);

            Movie m4 = new Movie("Rudy", 115, Genre.Biograhy);
            movies.Add(m4);

            Movie m5 = new Movie("Dead Poet Society", 140, Genre.ComedyDrama);
            movies.Add(m5);

            Movie m6 = new Movie("The Perks of Being a Wallflower", 106, Genre.Romance);
            movies.Add(m6);

            Movie m7 = new Movie("The Social Network", 121, Genre.Drama);
            movies.Add(m7);

            Movie m8 = new Movie("Snowden", 174, Genre.Thriller);
            movies.Add(m8);

            Movie m9 = new Movie("The Conjuring: The Devil Made Me Do It", 122, Genre.Horror);
            movies.Add(m9);

            Movie m10 = new Movie("The Hangover", 100, Genre.Comedy);
            movies.Add(m10);

            Console.WriteLine("Welcome to the Movie List Applitcation!");

            string userAnswer = "y";

            while (userAnswer == "y")
            {
                Console.WriteLine("There are 10 movies in this list");
                
                Genre[] acceptedGenres = (Genre[])Enum.GetValues(typeof(Genre));

                for (var i = 0; i < acceptedGenres.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {acceptedGenres[i]}");
                }

                Console.WriteLine("What genre are you interested in? Type a genre or enter the number of the corresponding genre you are interesting in.");
                string input = Console.ReadLine();

                Genre inputGenre = (Genre)Enum.Parse(typeof(Genre), input);

                foreach (String m in movies.Where(x => x.genre == inputGenre).Select(g => g.Title).ToList())
                {
                    Console.WriteLine(m);
                }
                
                Console.WriteLine("Continue (y/n)");
                userAnswer = Console.ReadLine();
            }
            
        }
    }
}
