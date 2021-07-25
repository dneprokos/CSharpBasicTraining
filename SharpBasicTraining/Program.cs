using System;
using SharpBasicTraining._0_FirstSteps;
using SharpBasicTraining._1_ConsoleAppAndIfStatements;
using SharpBasicTraining._2_DataTypes._2_ValueTypes;
using SharpBasicTraining._3_Arrays;
using SharpBasicTraining._4_Loops;

namespace SharpBasicTraining
{
    public class Program
    {
        private const string NoSuchCaseMessage = "No such case. Please make sure you've selected correct item number";
        private const string NotIntegerMessage = "Answer should be an Integer";


        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-----C# basic training-----\n");
            Console.WriteLine("The following lessons available:\n" +
                              "\n0 - Introduction C#" +
                              "\n1 - Conditional operators." +
                              "\n2 - Data Types." +
                              "\n3 - Arrays." +
                              "\n4 - Loops");

            Console.WriteLine("Please select a lesson you want to run:");
            var answer = Console.ReadLine();
            bool isInt = int.TryParse(answer, out var lessonNumber);

            if (!isInt)
                Console.WriteLine(NotIntegerMessage);
            else
            {
                switch (lessonNumber)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("-----C# basic training-----\n");
                        IntroductionToCSharp.BasicCSharpRun();
                        int sum = IntroductionToCSharp.Sum(2, 3);
                        Console.WriteLine(sum);
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("-----C# basic training-----\n");
                        ConditionalOperatorsPractice.RunLogic();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("-----C# basic training-----\n");
                        Console.WriteLine("The following data types available:\n\n1 - Reference types\n2 - Value Types.\n");

                        Console.WriteLine("Please select C# DataType:");
                        var answer2 = Console.ReadLine();
                        bool isInt2 = int.TryParse(answer2, out var dataTypeNumber);

                        if (!isInt2)
                            Console.WriteLine(NotIntegerMessage);
                        else
                        {
                            switch (dataTypeNumber)
                            {
                                case 1:
                                    Console.WriteLine("No methods available at this moment");
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("-----C# basic training-----\n");
                                    Console.WriteLine("The following value types available:\n\n1 - Boolean practice\n2 - Char practice.\n3 - Decimal practice.\n4 - Integer practice.\n");
                                    Console.WriteLine("Please select value type you want to run");
                                    var answer3 = Console.ReadLine();
                                    bool isInt3 = int.TryParse(answer3, out var valueTypeNumber);
                                    if (!isInt3)
                                        Console.WriteLine(NotIntegerMessage);
                                    else
                                    {
                                        switch (valueTypeNumber)
                                        {
                                            case 1:
                                                BooleanPractice.Run();
                                                break;
                                            case 2:
                                                CharPractice.Run();
                                                break;
                                            case 3:
                                                DecimalPractice.Run();
                                                break;
                                            case 4:
                                                IntegerPractice.Run();
                                                break;
                                            default:
                                                Console.WriteLine(NoSuchCaseMessage);
                                                break;
                                        }
                                    }

                                    break;
                                default:
                                    Console.WriteLine(NoSuchCaseMessage);
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("-----C# basic training-----\n");
                        Console.WriteLine("The following value types available:\n" +
                                          "\n1 - Single arrays" +
                                          "\n2 - Complex Arrays.\n");
                        Console.WriteLine("Please select array type:");
                        var answer4 = Console.ReadLine();
                        bool isInt4 = int.TryParse(answer4, out var arrayType);

                        if (!isInt4)
                            Console.WriteLine(NotIntegerMessage);
                        switch (arrayType)
                        {
                            case 1:
                                SingleArrays.Run();
                                break;
                            case 2:
                                MultiDimensionalArrays.Run();
                                break;
                            default:
                                Console.WriteLine(NoSuchCaseMessage);
                                break;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("-----C# basic training-----\n");
                        Console.WriteLine("The following Loops are available:\n" +
                                          "\n1 - For" +
                                          "\n2 - ForEach\n" +
                                          "\n2 - While\n" +
                                          "\n2 - DoWhile\n");
                        Console.WriteLine("Please select array type:");
                        var answer5 = Console.ReadLine();
                        bool isInt5 = int.TryParse(answer5, out var loopType);
                        if (!isInt5)
                            Console.WriteLine(NotIntegerMessage);
                        else
                        {
                            switch (loopType)
                            {
                                case 1:
                                    ForLoopPractice.RunForLoop();
                                    break;
                                case 2:
                                    ForEachLoopPractice.RunForEachLoop();
                                    break;
                                case 3:
                                    DoWhilePractice.RunWhileLoop();
                                    break;
                                case 4:
                                    DoWhilePractice.RunDoWhileLoop();
                                    break;
                                default:
                                    Console.WriteLine(NoSuchCaseMessage);
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine(NoSuchCaseMessage);
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
