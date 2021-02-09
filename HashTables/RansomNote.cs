using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgorithmDemosFeb2021
{
    public class RansomNote
    {
        public RansomNote()
        {

        }

        public  void checkMagazine(string[] magazine, string[] note)
        {
            HashSet<string> ransomNote = new HashSet<string>();

            foreach(var word in note)
            {
                if (magazine.Contains(word))
                {
                    ransomNote.Add(word);
                }
            }


            ransomNote.ToList().ForEach(x => Console.WriteLine($"Word Found { x }"));



        }


    }
}
