using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace AlgorithmDemosFeb2021
{
    public class RansomNote
    {
        public RansomNote()
        {

        }

        public void checkMagazine(string[] magazine, string[] note)
        {

            Hashtable ransomNote = new Hashtable();

            foreach (var word in note)
            {
                int wordIndex = Array.IndexOf(magazine, word);
                //check if index is in hashtable
                while (ransomNote.ContainsKey(wordIndex))
                {
                    wordIndex = Array.IndexOf(magazine, word, wordIndex + 1);
                }

                if (wordIndex > -1 && word.Equals(magazine[wordIndex]))
                {                  
                        ransomNote.Add(wordIndex, word);                  
                }
            }

            var foundValues = new string[ransomNote.Values.Count];
            ransomNote.Values.CopyTo(foundValues, 0);          

            
            
            var sortedNote = note.ToList();
            sortedNote.Sort();
            var sortedFoundValues = foundValues.ToList();
            sortedFoundValues.Sort();
            var isFound = sortedFoundValues.SequenceEqual(sortedNote);


            Console.WriteLine($"Ransom note created : { isFound}");



        }


    }
}
