using System;

namespace SharpBasicTraining._3_Arrays
{
    public class ArraysHomeTaskPractice
    {
        public static void LuckyNumberProblemSolving()
        {
            //Home task:
            //Ask to type a 6 digits number

            //Read a number from console

            //Make sure it's a number and it contains 6 digits

            //Answer if this number corresponds to lucky number 


            //NOTE 1: Lucky ticket number - Ticket number where SUM of the first 3 digits corresponds to a SUM of the last 3 digits
            //NOTE 2: HINTS:
            // 1) You need to convert your number to char array 
            // 2) You need to convert char back to int. There are few ways to do it. I think should know how to do it 
            Console.WriteLine("\nPlease enter 6 digits number");
            var readNumbers = Console.ReadLine();

            bool isIntegerType = int.TryParse(readNumbers, out var numbers);

            //There is also possibility to combine it in one if. I just decided to separate each message
            if (string.IsNullOrEmpty(readNumbers))
            {
                Console.WriteLine("Value should not be null or empty");
                return;
            }
            if (!isIntegerType)
            {
                Console.WriteLine("Value should contain integers only");
                return;
            }
            if (readNumbers.Length != 6)
            {
                Console.WriteLine("Value should have 6 digits length");
                return;
            }

            //LINQ. I haven't show a LINQ, so probably I should use another approach
            //int [] individualDigits = readNumbers
            //    .ToCharArray()
            //    .Select(ch => int.Parse(ch.ToString()))
            //    .ToArray();

            var individualDigits = new int[6];

            for (int i = 0; i < individualDigits.Length; i++)
            {
                individualDigits[i] = numbers % 10;
                numbers /= 10;
            }

            var firstPart = individualDigits[0] + individualDigits[1] + individualDigits[2];
            var secondPart = individualDigits[3] + individualDigits[4] + individualDigits[5];

            bool isEqual = (firstPart == secondPart);

            Console.WriteLine(isEqual ? $"{readNumbers} is lucky number)))" : $"{readNumbers} is not lucky number(((");
        }
    }
}
