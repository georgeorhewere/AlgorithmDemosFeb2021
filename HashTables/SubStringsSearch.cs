using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmDemosFeb2021
{
    public class SubStringsSearch
    {
        private string wordToCheck;
        public SubStringsSearch()
        {

        }



        public void getNumberOfAnagrams(string inputWord)
        {

            var wordArray = inputWord.ToCharArray();
            // get length of half the string

            int inputMidpoint = (int)Math.Ceiling((double)wordArray.Length / 2);
            Console.WriteLine($"mid point of string { inputMidpoint }");
           
            for(int x = 0; x < inputMidpoint; x++)
            {
                int wordLength = x + 1;
                var substring = wordArray.Take(wordLength);
                Console.WriteLine($" substring instance { string.Join("",substring) }");
                // check for anagram
                var anagram = wordArray.Skip(wordLength);
                Console.WriteLine($" anagram container to check { string.Join("", anagram) }");
                // use set operations to check 
                var intersect = wordArray.Intersect(substring);
                Console.WriteLine($" anagram intersction check { string.Join(",", intersect) }");


            }



            //var anagramCharList = wordArray.GroupBy(x => x)
            //                            .Where(g => g.Count() > 1)
            //                            .ToList();
            //if (anagramCharList.Any())
            //{
            //    Console.WriteLine($"Found  possible anagrams for {inputWord}");
            //    anagramCharList.ForEach(x => Console.WriteLine($"{x.Key.ToString()} - {x.Count()}"));
            //}
            //else
            //{
            //    Console.WriteLine($"No anagrams for {inputWord}");
            //}


            //



        }



    }
}
