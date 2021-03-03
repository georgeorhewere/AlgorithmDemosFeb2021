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
            int count = 0;

            // check if there is possibility of an anagram
            //int anagramCount = 0;
            Console.WriteLine($"input : { inputWord }");

            for (int i = 1; i < inputWord.Length; i++)
            {
                Dictionary<string, int> found = new Dictionary<string, int>();
                // Starting index of our sliding window
                for (int j = 0; j + i <= inputWord.Length; j++)
                {
                    string substr = inputWord.Substring(j, i);
                    var splitArr = substr.Split("");
                    Array.Sort(splitArr);
                    substr = string.Join("", splitArr);
                    if (found.ContainsKey(substr))
                    {
                        count += found[substr];
                        found[substr]++;
                    }
                    else
                    {
                        found.Add(substr, 1);
                    }
                }

                Console.WriteLine($"");
            }

            Console.WriteLine($" anagram count { count }");


        }



    }
}
