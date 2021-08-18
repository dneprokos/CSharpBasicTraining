using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpBasicTraining._5_DataStructures
{
    public class DictionaryDataStructurePractice
    {
        public static void RunDictionary()
        {
            //Initialize dictionary
            var statuses = new Dictionary<int, string>();

            //Another example of the Dictionary
            var test = new Dictionary<string, string>();
            
            //Fill dictionary
            statuses.Add(1, "New");
            statuses.Add(2, "In Progress");
            statuses.Add(3, "Finalized");

            //Clear all statuses
            statuses.Clear();

            //Reinitialize dictionary with help of Initializer
            statuses = new Dictionary<int, string>
            {
                {1, "New"},
                {2, "In Progress"},
                {3, "Finalized"},
            };

            var statusKeys = statuses.Keys;
            var statusValues = statuses.Values;
            var statusCount = statuses.Count;

            statusKeys.ToList().ForEach(key => Console.WriteLine($"Key {key} has a value {statuses[key]}"));

            //IMPORTANT: Record with the same KEY cannot be added


            //TODO: Home task. Create you own dictionary. It can be any datatype inside.
            //TODO:Fulfill it. Ask to print value in the console. 
            //TODO: If value exist - Print "Key and value" in the console
            //TODO: If value does not exist - Save this value to dictionary and print "New record was saved Key - Value" 
        }
    }
}
