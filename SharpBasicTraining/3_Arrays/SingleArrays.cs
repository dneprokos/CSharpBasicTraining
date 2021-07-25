using System;

namespace SharpBasicTraining._3_Arrays
{
    public class SingleArrays
    {
        public static void Run()
        {
            //Declaration and initialization
            int [] arrayOfIntegers = new int[5];
            
            //Non initialized array
            int[] nonInitializedArray;

            arrayOfIntegers[0] = 5;
            arrayOfIntegers[1] = 7;
            arrayOfIntegers[4] = 10;
            arrayOfIntegers[4] = 9;

            
            Console.WriteLine("arrayOfIntegers length is " + arrayOfIntegers.Length);
            Console.WriteLine("arrayOfIntegers last element is " + arrayOfIntegers[arrayOfIntegers.Length - 1]);
            Console.WriteLine("arrayOfIntegers third element is " + arrayOfIntegers[2]);

            int[] arrayOfIntegers2 = new int[10]; //Init an array with 10 elements. Each of them is equal to 0;

            //Declaration, initialization and assignment (With array length)
            string [] arrayOfStrings = new string [2] {"Testing", "Development"};

            //Declaration, initialization and assignment (Without array length. It will be created automatically)
            bool [] arrayOfBooleans = new[] {true, false, false, true};

            //Array of reference type
            TestPersonsClassForArray[] personsClass = new TestPersonsClassForArray[3];
            personsClass[1] = new TestPersonsClassForArray {Age = 16, IsValid = true, Name = "Paul"};
            personsClass[personsClass.Length -1] = new TestPersonsClassForArray { Age = 34, IsValid = false, Name = "Kostia" };

            personsClass.SetValue(new TestPersonsClassForArray { Age = 40, IsValid = false, Name = "David" }, 0 );
            
            

            Console.WriteLine($"First person in the array is: ");
            personsClass[0].PrintPersonData();
            Console.WriteLine();


            foreach (var person in personsClass)
            {
                if (person != null)
                {
                    person.PrintPersonData();
                    Console.WriteLine("Is person adult?:" + person.IsAdult());
                }
                else
                {
                    Console.WriteLine("Person does not exist\n");
                }
            }
        }
    }
}
