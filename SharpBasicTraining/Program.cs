using System;

namespace SharpBasicTraining
{
    public class Program
    {
        private const string Question = "Hello! What is you name?";
        private const string Question2 = "How old are you?";
        private const string Greating = "Hello ";

        private static string Answer;
        private static string Answer2;

        public static void Main(string[] args)
        {
            Console.WriteLine(Question);
            Answer = Console.ReadLine();
            
            Console.WriteLine(Question2);
            Answer2 = Console.ReadLine();

            int age = int.Parse(Answer2);

            switch (age)
            {
                case 0 - 7:
                    Console.WriteLine(Greating + Answer + " Sorry path is restricted");
                    break;
                case 7 - 12:
                    Console.WriteLine(Greating + Answer + " Please go. You have a discount");
                    break;
                default:
                    Console.WriteLine(Greating + Answer + " Please go and enjoy");
                    break;
            }


            //if (age > 0 && age < 99)
            //{
            //    if (age < 7)
            //    {
            //        Console.WriteLine(Greating + Answer + " Sorry path is restricted");
            //    }
            //    else if (int.Parse(Answer2) < 12)
            //    {
            //        Console.WriteLine(Greating + Answer + " Please go. You have a discount");
            //    }
            //    else
            //    {
            //        Console.WriteLine(Greating + Answer + " Please go and enjoy");
            //    }
            //}
            
            Console.ReadLine();
        }
    }
}
