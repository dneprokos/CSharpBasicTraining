using System;

namespace SharpBasicTraining._4_Loops
{
    public class DoWhilePractice
    {
        public static void RunWhileLoop()
        {
            //TODO: Please never use it. It will start infinite loop
            //while (true)
            //{
            //    Console.WriteLine("Infinite loop");
            //}

            //Will print Happy birthday each year before 10 years.
            var years = 1;
            while (years < 10)
            {
                Console.WriteLine($"Happy birthday! Now you're {years} year/s old");
                years++;
            }

            //Will never print it because year already 1
            while (years < 1)
            {
                Console.WriteLine("You'll never see this message");
            }
        }

        public static void RunDoWhileLoop()
        {
            
        }
        public static void PrintWhileIntegerHomeTask()
        {
            bool isInteger;

            Console.Clear();
            Console.WriteLine("Prints while integer: \n");

            do
            {
                string input = Console.ReadLine();
                isInteger = int.TryParse(input, out var result);

                if (isInteger)
                    Console.WriteLine($"You've entered a new text of integer type {result}");
            }
            while (isInteger);

            Console.WriteLine("It was not an integer");

            //Home task:
            //Read text from console while it's integer
            //Each time you need to print this text.
            //Print text template is: "You've entered a new text of integer type {<Your integer>}"
        }
    }
}
