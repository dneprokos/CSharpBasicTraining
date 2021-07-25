using System;

namespace SharpBasicTraining._2_DataTypes._2_ValueTypes
{
    public class CharPractice
    {
        public static void Run()
        {
            char a = 'a';
            char b = 'A';
            char c = 'C';

            var newString2 = a.ToString();

            string newString = new string(new[] {a, b, c});

            Console.WriteLine(newString2);
        }
    }
}
