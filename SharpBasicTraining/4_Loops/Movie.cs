using System;

namespace SharpBasicTraining._4_Loops
{
    public class Movie
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string[] Countries { get; set; }

        public Movie(string name, int releaseYear)
        {
            Name = name;
            ReleaseYear = releaseYear;
        }

        public Movie(string name, int releaseYear, string[] countries)
        {
            Name = name;
            ReleaseYear = releaseYear;
            Countries = countries;

            Console.WriteLine("Movie was populated");
        }
    }
}
