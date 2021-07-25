using System;

namespace SharpBasicTraining._4_Loops
{
    public class DoWhilePractice
    {
        public static void RunWhileLoop()
        {
            //TODO: Please never use it. It will be infinite loop
            //while (true)
            //{
            //    Console.WriteLine("Infinite loop");
            //}

            var years = 1;
            while (years < 10)
            {
                Console.WriteLine($"Happy birthday! You're {years} years old");
                years++;
            }
        }

        public static void RunDoWhileLoop()
        {

        }
    }
}
