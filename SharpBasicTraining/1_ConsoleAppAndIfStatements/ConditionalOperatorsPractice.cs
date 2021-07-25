using System;

namespace SharpBasicTraining._1_ConsoleAppAndIfStatements
{
    public class ConditionalOperatorsPractice
    {
        private const string Question = "Hello! What is you name?";
        private const string Question2 = "How old are you?";
        private const string Greeting = "Hello ";

        private static string _answer;
        private static string _answer2;

        public static void RunLogic()
        {
            Console.WriteLine(Question);
            _answer = Console.ReadLine();

            Console.WriteLine(Question2);
            _answer2 = Console.ReadLine();

            int age = int.Parse(_answer2);

            switch (age)
            {
                case var n when n > 0 && n < 7:
                    Console.WriteLine(Greeting + _answer + " Sorry path is restricted");
                    break;
                case var n when n >= 7 && n <= 12:
                    Console.WriteLine(Greeting + _answer + " Please go. You have a discount");
                    break;
                default:
                    Console.WriteLine(Greeting + _answer + " Please go and enjoy");
                    break;
            }

                //if (age > 0 && age < 99)
            //{
            //    if (age < 7)
            //    {
            //        Console.WriteLine(Greeting + Answer + " Sorry path is restricted");
            //    }
            //    else if (int.Parse(Answer2) < 12)
            //    {
            //        Console.WriteLine(Greeting + Answer + " Please go. You have a discount");
            //    }
            //    else
            //    {
            //        Console.WriteLine(Greeting + Answer + " Please go and enjoy");
            //    }
            //}

            Console.ReadLine();
        }


        
    }
}
