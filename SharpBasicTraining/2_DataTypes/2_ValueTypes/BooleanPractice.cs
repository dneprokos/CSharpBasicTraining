using System;

namespace SharpBasicTraining._2_DataTypes._2_ValueTypes
{
    public class BooleanPractice
    {
        public static void Run()
        {
            bool isChecked = true;

            Console.WriteLine(isChecked.Equals(false));
            Console.WriteLine($"isChecked data type is: {isChecked.GetType()}");


            bool defaultValue = false;
            Console.WriteLine($"Boolean default value is {defaultValue}");
        }
    }
}
