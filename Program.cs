using System;

namespace AlgorithmDemosFeb2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Tetst");

            testRansomNote();
            Console.ReadKey();
        }


        public static void testRansomNote()
        {
            string[] magazine = new string[] { "give", "me", "one", "grand", "today", "night" };
            string[] note = new string[] { "give", "one", "grand", "today" };

            RansomNote ransomCreator = new RansomNote();
            ransomCreator.checkMagazine(magazine, note);
            Console.WriteLine();
            Console.WriteLine("Test 2");
            magazine = new string[] { "two", "times", "three", "is", "not", "four" };
            note = new string[] { "two", "times","two", "is", "four" };
            ransomCreator.checkMagazine(magazine, note);

        }
    }
}
