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

            var duplicateChars = wordArray.GroupBy(x => x).Where(g => g.Count() > 1);
            // check if there is possibility of an anagram
            int anagramCount = 0;

            if (duplicateChars.Any())
            {

                // get length of half the string
                int inputMidpoint = (int)Math.Ceiling((double)wordArray.Length / 2);
                Console.WriteLine($"mid point of string { inputMidpoint }");
             
                for (int x = 0; x < inputMidpoint; x++)
                {
                    int wordLength = x + 1;
                    var substring = wordArray.Take(wordLength);
                    Console.WriteLine($" substring instance { string.Join("", substring) }");
                    // check for anagram
                    var anagram = wordArray.Skip(wordLength);
                    Console.WriteLine($" anagram container to check { string.Join("", anagram) }");
                    // use set operations to check 
                    var intersect = anagram.Intersect(substring);
                    if (intersect.Any())
                        anagramCount++;
                }

                //process duplicate characters
                duplicateChars.ToList().ForEach(x => Console.WriteLine($"Duplicates { x.Key }"));
                //Console.WriteLine($" duplicate count {  }");
            }


            Console.WriteLine($" anagram count { anagramCount }");


        }



    }
}
