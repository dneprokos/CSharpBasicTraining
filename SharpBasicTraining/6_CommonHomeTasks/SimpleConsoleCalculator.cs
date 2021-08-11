using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpBasicTraining._6_CommonHomeTasks
{
    public static class SimpleConsoleCalculator
    {
        //TODO: Task Create simple console calculator

        //Calculators asks to enter first value
        //Calculator asks to enter operation name (+-*/)
        //Calculators asks to enter second value
        //Calculator performs operation

        /// <summary>
        /// Runs calculator in a while loop
        /// </summary>
        public static void RunCalculatorApp()
        {
            bool continueRun = true;

            while (continueRun)
            {
                RunCalculatorLogic();
                Console.WriteLine("1 - Try again?\n2 - Exit\n");

                string text = Console.ReadLine();
                var isParsed = int.TryParse(text, out var option);

                if (isParsed && option == 1)
                    continue;
                continueRun = false;
            }
        }

        /// <summary>
        /// Runs calculator logic
        /// </summary>
        public static void RunCalculatorLogic()
        {
            double? firstValue = null;
            double? secondValue = null;
            string operation = null;
            string exception = string.Empty;

            double? result = null;
            bool canBeParsed = false;

            while (!canBeParsed)
            {
                ConsoleCalculatorHeader(null, null, null);
                Console.WriteLine("Please enter first value (Value should be double)");
                var text = Console.ReadLine();
                canBeParsed = double.TryParse(text, out var parsedValue1);

                if (canBeParsed)
                    firstValue = parsedValue1;
            }
            canBeParsed = false;

            while (!canBeParsed)
            {
                ConsoleCalculatorHeader(firstValue, null, null);

                if (exception != string.Empty)
                    Console.WriteLine(exception);
                Console.WriteLine("Please enter operation you want to perform (+-*/)\n");

                var text = Console.ReadLine();
                var possibleSigns = new List<string> {"+", "-", "/", "*"};

                if (string.IsNullOrEmpty(text) || text.Length != 1 || possibleSigns.All(ch => ch != text))
                {
                    exception = "Unsupported operation. Please make sure you have entered any of the supported operations: +, -, *, / ";
                    continue;
                }

                operation = text;
                canBeParsed = true;
                exception = string.Empty;
            }
            canBeParsed = false;
            while (!canBeParsed)
            {
                ConsoleCalculatorHeader(firstValue, null, operation);

                Console.WriteLine("Please enter second value (Value should be double)");
                var text = Console.ReadLine();
                canBeParsed = double.TryParse(text, out var parsedValue2);

                if (canBeParsed && parsedValue2 == 0 && operation == "/")
                {
                    Console.WriteLine("We cannot divide on 0");
                    canBeParsed = false;
                }
                else if (canBeParsed)
                    secondValue = parsedValue2;
            }

            switch (operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "/":
                    result = firstValue / secondValue;
                    break;
                case "*":
                    result = firstValue * secondValue;
                    break;
                default:
                    Console.WriteLine("Unexpected operation.");
                    break;
            }

            ConsoleCalculatorHeader(firstValue, secondValue, operation);
            // ReSharper disable once PossibleInvalidOperationException
            Console.WriteLine($"\nResult: '{firstValue} {operation} {secondValue}' = {result.Value}");
        }

        private static void ConsoleCalculatorHeader(double? firstValue, double? secondValue, string operation)
        {
            Console.Clear();
            Console.WriteLine("###Simple console calculator###\n");
            Console.WriteLine($"FIRST_VALUE = {firstValue}");
            Console.WriteLine($"OPERATION = '{operation}'");
            Console.WriteLine($"SECOND_VALUE = {secondValue}\n");
        }
    }
}
