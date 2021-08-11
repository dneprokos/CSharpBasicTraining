using System;
using System.Linq;

namespace SharpBasicTraining._4_Loops
{
    public class ForEachLoopPractice
    {
        public static void RunForEachLoop()
        {
            string[] movieNames = {"Mad Max", "The Rising Hawk", "Crocodile Dundee", "Winter on Fire", "The King"};

            Console.WriteLine("Movies contain 'The' article");
            foreach (var movieName in movieNames)
            {
                if (movieName.Contains("The"))
                {
                    Console.WriteLine(movieName);
                }
            }
        }

        public static void RunGetMoviesFromAustralia()
        {
            //Initial condition: Movies list
            Movie[] movies = {
                new Movie("Mad Max", 1979, new []{"Australia"}),
                new Movie("Crocodile Dundee", 1986, new []{"USA", "Australia"}),
                new Movie("The Rising Hawk", 1999, new []{"USA", "Ukraine"}),
                new Movie("Room", 2015, new []{"Canada", "Ireland", "United Kingdom", "USA"}),
                new Movie("Winter on Fire", 2015, new []{"Ukraine", "United Kingdom", "USA"}),
                new Movie("Nayakan", 1987, new []{"India"}),
                new Movie("Munich", 2005, new []{"USA", "Canada"}),
                new Movie("The King", 2019, new []{"USA", "United Kingdom", "Australia"}),
                new Movie("Strange Brew", 1983, new []{"Canada"})
            };

            Console.Clear();
            Console.WriteLine("Movies from Australia: \n");

            foreach (var movie in movies)
            {
                //We don't know what is linq yet
                if (movie.Countries.Any(c => c.Contains("Australia")))
                {
                    Console.WriteLine($"{movie.Name} - {movie.ReleaseYear} - {string.Join(',', movie.Countries)}");
                }
            }

            //Print movies from Australia (Template: Movie name - Release year - Country1, Country2, Country...n) 

        }
    }
}
