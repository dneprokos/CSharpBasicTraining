using System;

namespace SharpBasicTraining._2_DataTypes
{
    public class ValueTypesVsReferenceTypes
    {
        public static void Run()
        {
            //<-------------------Value types------------------------------>

            int a = 7;
            int b = a;

            Console.WriteLine($"Original a value: {a}");
            Console.WriteLine($"Original b value: {b}");


            a = 9;

            Console.WriteLine($"a after modification: {a}");
            Console.WriteLine($"b after modification: {b}");



            //<-------------------String------------------------------------>

            string c = "Test";
            string d = c;

            Console.WriteLine($"Original c value: {c}");
            Console.WriteLine($"Original d value: {d}");

            c = "Not test";

            Console.WriteLine($"c after modification: {c}");
            Console.WriteLine($"d after modification: {d}");


            //<-------------------Reference types:--------------------------->

            var employer1 = new Person
            {
                FirstName = "David",
                LastName = "Beckham",
                Dob = new DateTime(1975, 5, 02)
            };


            Person employer2 = employer1;

            var employee3 = new Person
            {
                FirstName = "Kostia",
                LastName = "Teltov"
            };

            employee3.Dob = new DateTime(1986, 09, 19);


            Console.WriteLine($"Original employer1 value: {employer1.FirstName} {employer1.LastName} {employer1.Dob.Value.ToShortDateString()}");
            Console.WriteLine($"Original employer2 value: {employer2.FirstName} {employer2.LastName} {employer2.Dob.Value.ToShortDateString()}");

            employer1.LastName = "Giggs";
            employer2.FirstName = "Archy";

            Console.WriteLine($"Update employer1 value: {employer1.FirstName} {employer1.LastName} {employer1.Dob.Value.ToShortDateString()}");
            Console.WriteLine($"Update employer2 value: {employer2.FirstName} {employer2.LastName} {employer2.Dob.Value.ToShortDateString()}");
            Console.WriteLine($"Update employer2 value: {employee3.FirstName} {employee3.LastName} {employee3.Dob.Value.ToShortDateString()}");
        }
    }
}

