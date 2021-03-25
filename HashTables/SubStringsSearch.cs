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



        public int getNumberOfAnagrams(string inputWord)
        {

            int count = 0;
            

            for (int i = 1; i < inputWord.Length; i++)
            {
                Dictionary<string, int> found = new Dictionary<string, int>();

                for (int j = 0; j + i <= inputWord.Length; j++)
                {
                    string subStringCheck = inputWord.Substring(j, i);
                    char[] splitArr = subStringCheck.ToCharArray();
                    Array.Sort(splitArr);

                    subStringCheck = string.Join("", splitArr);

                    if (found.ContainsKey(subStringCheck))
                    {
                        count += found[subStringCheck];
                        found[subStringCheck]++;
                    }
                    else
                    {
                        found.Add(subStringCheck, 1);
                    }
                    

                }
            }
            return count;


        }



    }
}
