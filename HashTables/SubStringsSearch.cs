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

            wordArray.GroupBy(x => x).Where(g => g.Count() > 1).ToList().ForEach(x => Console.WriteLine($"{x.Key.ToString()} - {x.Count()}"));
            

            
        }



    }
}
