using System;

namespace SharpBasicTraining._2_DataTypes._2_ValueTypes
{
    public class DecimalPractice
    {
        public static void Run()
        {
            decimal price = 99.99M;
            decimal price2 = 45.55M;

            float x = 2.2F;

            decimal totalPrice = price + price2;

            Console.WriteLine(totalPrice);
        }
    }
}
