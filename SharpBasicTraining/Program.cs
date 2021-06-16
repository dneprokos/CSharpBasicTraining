using System;

namespace SharpBasicTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Variable declaration
            string message;

            //Assign variable
            message = " Have a nice day!";

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
