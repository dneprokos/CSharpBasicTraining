using System;

namespace SharpBasicTraining._0_FirstSteps
{
    public class IntroductionToCSharp
    {
        public static void BasicCSharpRun()
        {
            Console.WriteLine("####Basic of C#. Hello world and variables#####");

            //Variable declaration
            string message;

            //Assign variable
            message = " Have a nice day!";

            //Declare and assign
            string message2 = "Hello World!";

            //Print variable
            Console.WriteLine("Hello Retail Express Team" + message);

            //Assign new value to variable
            message = "Starting calculation...";

            //Print new value
            Console.WriteLine(message);

            //Calculate a sum from our new method
            Console.WriteLine(Sum(2, 3));

            //Postpone console close
            Console.ReadLine();
        }

        public static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
