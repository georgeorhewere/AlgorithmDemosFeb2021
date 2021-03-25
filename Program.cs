using System;
using System.Collections.Generic;

namespace AlgorithmDemosFeb2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Tetst");

            

            testAnagramsAlgorithm();
            //testRansomNote();
            //readRansomFromFile();
            Console.ReadKey();

        }


        public static void testRansomNote()
        {
            string[] magazine = new string[] { "give", "me", "one", "grand", "today", "night" };
            string[] note = new string[] { "give", "one", "grand", "today" };
            bool found = false;

            RansomNote ransomCreator = new RansomNote();
            found = ransomCreator.checkMagazine2(magazine, note);

            Console.WriteLine($"ransome note created : {found }");

            Console.WriteLine();
            Console.WriteLine("Test 2");
            found = false;
            magazine = new string[] { "two", "times", "three", "is", "not", "four" };
            note = new string[] { "two", "times", "two", "is", "four" };
            ransomCreator.checkMagazine2(magazine, note);
            Console.WriteLine($"ransome note created : {found }");

        }

        public static void readRansomFromFile()
        {
            IEnumerable<string> text = System.IO.File.ReadLines(@"F:\Training\Algorithms\Hackerrank\ctci-ransom\input\input19.txt");
            List<string> input = new List<string>(text);
            RansomNote ransomCreator = new RansomNote();
            var found = ransomCreator.checkMagazine2(input[1].Split(' '), input[2].Split(' '));

            Console.WriteLine($"ransome note created : {found }");

            Console.WriteLine(input.Count);


        }


        public static void testAnagramsAlgorithm()
        {
            SubStringsSearch manager = new SubStringsSearch();
            string inputWord = "abba";
            int result = manager.getNumberOfAnagrams(inputWord);
            Console.WriteLine($"number of anagrams: {result}");
            inputWord = "abcd";
            result = manager.getNumberOfAnagrams(inputWord);
            Console.WriteLine($"number of anagrams: {result}");
            inputWord = "kkkk";
            result = manager.getNumberOfAnagrams(inputWord);
            Console.WriteLine($"number of anagrams: {result}");


        }
    }
}
