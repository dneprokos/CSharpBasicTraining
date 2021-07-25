using System;

namespace SharpBasicTraining._2_DataTypes._2_ValueTypes
{
    public class IntegerPractice
    {
        public static void Run()
        {
            //int
            Int32 a = 7;
            int a1 = 7;

            //short
            Int16 b = 8;
            short b1 = 7;

            //long
            Int64 c = 1;
            long c1 = long.MaxValue;

            long total = a + b;
            Console.WriteLine(total);

            int shortValue = (short) c1 <= short.MaxValue ? (short)c1 : 1;

            Console.WriteLine(shortValue);
        }
    }
}
