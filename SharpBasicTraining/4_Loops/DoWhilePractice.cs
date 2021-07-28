﻿using System;

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

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Will be print only during first iteration");
                isTrue = false;
            }


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
            var years = 1;

            do
            {
                Console.WriteLine("You'll see this message once because we use Do While");
            } while (years < 1);


            do
            {
                Console.WriteLine("Do while practice");
                years++;
            } while (years < 3);
        }



        public static void RunDoWhileHomeTask()
        {
            //Home task:
            //Read text from console while it's integer
            //Each time you need to print this text.
            //Print text template is: "You've entered a new text of integer type {<Your integer>}"
        }
    }
}
