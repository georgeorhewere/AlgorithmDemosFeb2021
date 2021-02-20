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

            var anagramCharList = wordArray.GroupBy(x => x)
                                        .Where(g => g.Count() > 1)
                                        .ToList();
            if (anagramCharList.Any())
            {
                Console.WriteLine($"Found  possible anagrams for {inputWord}");
                anagramCharList.ForEach(x => Console.WriteLine($"{x.Key.ToString()} - {x.Count()}"));
            }
            else
            {
                Console.WriteLine($"No anagrams for {inputWord}");
            }

                    
                    //
            

            
        }



    }
}
