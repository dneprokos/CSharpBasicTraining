using System;
using System.Linq;

namespace SharpBasicTraining._2_DataTypes._1_ReferenceTypes
{
    public class StringTestClass
    {
        public static void RunExample()
        {
            string accio = "Summoning Charm; used to summon objects toward the caster (usually from a long distance)";
            string alohomora = "used to unlock and open doors";
            string avadaKedavra = "the Killing Curse; causes a green flash of light; Harry Potter is the only known survivor of this curse; one of three Unforgivable Curses banned by the Ministry of Magic";
            string crucio = "causes the victim extreme pain; one of three Unforgivable Curses banned by the Ministry of Magic";
            string expectoPatronum = "used to cast a Patronus (a physical manifestation of one’s most positive feelings), which guards against dementors and can be used for communications";
            string expelliarmus = "used to disarm another wizard";
            string reducto = " Reductor Curse; breaks objects and in its strongest form has the ability to disintegrate them ";

            //Contains
            bool isContainS = accio.Contains('S');
            Console.WriteLine($"Does accio text contains S: {isContainS}");

            //EndsWith
            bool isEndWithDoors = alohomora.EndsWith("doors");

            //StartsWith
            bool isStartWithThe = avadaKedavra.StartsWith("the");

            //Equals
            bool isEqualToExpected = expelliarmus.Equals("used to disarm another wizard");

            //Insert
            var newReducto = reducto.Insert(0, "Reducto is a spell:");
            var newReducto2 = $"Reducto is a spell: {reducto}";

            //IndexOf. Returns -1 if not found
            var firstIndexOfC = crucio.IndexOf('c');

            //LastIndexOf. Returns -1 if not found
            var lastIndexOfC = crucio.LastIndexOf('c');

            //ToLower or ToHigher
            var expectoPatronumLower = expectoPatronum.ToLowerInvariant();
            var expectoPatronumHigher = expectoPatronum.ToUpperInvariant();

            //TrimStart, TrimEnd, Trim
            var reductoTrimStart = reducto.TrimStart();
            var reductoTrimEnd = reducto.TrimEnd();
            var reductoTrim = reducto.Trim();

            //Replace.
            var replaceSumonningOnInwoking = accio.Replace("Summoning", "Invoking");

            //Split
            var splitByEmptySpace = accio.Split(' ').ToList();
            var splitBySemicolon = accio.Split(';').ToList();

            //Substring
            var halfedAlohomora = alohomora.Substring(0, alohomora.Length / 2);

            //Remove
            var expectoPatronumRemovedFromLastIndexOfR = expectoPatronum
                .Remove(expectoPatronum.LastIndexOf("r") + 1);

            //ToChar array
            var expelliarmusAsCharArray = expelliarmus.ToCharArray();



            //TODO:Home Task Print explanation foreach of the examples
        }
    }
}
