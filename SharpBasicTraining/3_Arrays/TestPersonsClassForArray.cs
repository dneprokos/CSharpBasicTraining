using System;

namespace SharpBasicTraining._3_Arrays
{
    public class TestPersonsClassForArray
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsValid { get; set; }

        public void PrintPersonData()
        {
            Console.WriteLine($"Please meet a person:\n Age: {Age}\nIsValid: {IsValid}\nName: {Name}\n");
        }

        public bool IsAdult()  => Age > 19;
    }
}
