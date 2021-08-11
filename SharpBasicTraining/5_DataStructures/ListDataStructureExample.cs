using System;
using System.Collections.Generic;
using System.Linq;
using SharpBasicTraining._4_Loops;

namespace SharpBasicTraining._5_DataStructures
{
    public class ListDataStructureExample
    {
        public static void ListRunExample()
        {
            var movieNames = new List<string>
            {
                "Test1", "Test2", "Test3"
            };

            var movies = new List<Movie>()
            {
                new Movie("Test movie", 2017),
                new Movie("Test movie2", 2020),
            };

            
            //Add one item to the list
            movies.Add(new Movie("Movie3", 2019));

            //Add new list
            var newMoviesToAdd = new List<Movie>
            {
                new Movie("Movie4", 2011),
                new Movie("Movie5", 2011)
            };

            movies.AddRange(newMoviesToAdd);

            //Get movies count == similar to Length for array
            Console.WriteLine("Movies count is: " + movies.Count);

            //Check if List contains some record
            bool isContain = movies.Contains(new Movie("Movie4", 2011));

            //Clears all the list
            movies.Clear();

            //Convert array to list
            int[] testArray = {2, 3, 5};
            var testArrayConvertedToLst = testArray.ToList();


            //ForEach print each movie Name and Year
            movies.ForEach(movie => Console.WriteLine($"{movie.Name} - {movie.ReleaseYear}"));
        }
    }
}
