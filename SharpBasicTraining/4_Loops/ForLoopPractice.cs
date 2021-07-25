using System;

namespace SharpBasicTraining._4_Loops
{
    public class ForLoopPractice
    {
        public static void RunForLoop()
        {
            //Random class. Generates random numbers
            var random = new Random();
            int[] arrayOfIntegers = new int[random.Next(5, 20)];

            //Looping with increment and assign values
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                arrayOfIntegers[i] = random.Next(0, 200);
                if (i == arrayOfIntegers.Length - 1)
                    Console.WriteLine();
            }

            //Looping with decrement and read values starting from the last element
            for (int i = arrayOfIntegers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{nameof(arrayOfIntegers)} element {i} is equal to {arrayOfIntegers[i]}");
            }

            //Logic inside of the loop.Checking if value is Odd number
            Console.WriteLine();
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] % 2 == 0)
                    Console.WriteLine($"arrayOfIntegers3 element {i} is Odd number");
            }

            //Home task for students
            int[] reversedArrayOfIntegers = new int[arrayOfIntegers.Length];
            for (int i = arrayOfIntegers.Length - 1, j = 0; i > -1; i-- )
            {
                reversedArrayOfIntegers[i] = arrayOfIntegers[j];
                j++;
            }

            for (int i = 0; i < reversedArrayOfIntegers.Length; i++)
            {
                Console.WriteLine($"reversedArrayOfIntegers element with index {i} has a value {reversedArrayOfIntegers[i]}");
            }

        }
    }
}
