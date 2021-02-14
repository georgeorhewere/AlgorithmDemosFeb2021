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

        public bool checkMagazine(string[] magazine, string[] note)
        {

            Hashtable ransomNote = new Hashtable();

            List<string> sortedNote = note.ToList();
            sortedNote.Sort();
            List<string> sortedMagazine = magazine.ToList();
            sortedMagazine.Sort();

            var testSort = sortedMagazine.Intersect(sortedNote).ToList();

            foreach (var word in sortedNote)
            {
                //var wordListInMagagzine = Array.FindAll(sortedMagazine.ToArray(), x=> x.Equals(word));
                //wordListInMagagzine.ToList().ForEach(x => Console.WriteLine($"item {x} at {sortedMagazine.IndexOf(x)}"));


                int wordIndex = Array.BinarySearch(sortedMagazine.ToArray(), word);
                

                //check if index is in hashtable

                while (ransomNote.ContainsKey(wordIndex))
                {
                    int lengthOfRange = sortedMagazine.ToArray().Length - wordIndex - 1;
                    int startIndex = wordIndex + 1;
                    wordIndex = Array.BinarySearch(sortedMagazine.ToArray(), startIndex, lengthOfRange, word);
                }

                if (wordIndex > -1 && word.Equals(sortedMagazine[wordIndex]))
                {
                    ransomNote.Add(wordIndex, word);
                    
                }
                else
                {
                    break;
                }
            }


            var foundValues = new string[ransomNote.Values.Count];
            ransomNote.Values.CopyTo(foundValues, 0);

            var sortedFoundValues = foundValues.ToList();
            sortedFoundValues.Sort();

            return sortedFoundValues.SequenceEqual(sortedNote);

        }

        public bool checkMagazine2(string[] magazine, string[] note)
        {
            Hashtable ransomNote = new Hashtable();

            List<string> sortedNote = note.ToList();
            sortedNote.Sort();
            List<string> sortedMagazine = magazine.ToList();
            sortedMagazine.Sort();

            //get items not available in the magazine list
            var exceptItems = sortedNote.Except(sortedMagazine).ToList();
            
            if (exceptItems.Any())
            {
                Console.WriteLine("Cann0t form note");
                return false;
            }
            else
            {
                Console.WriteLine("Process note");
                // checked intersection to determine the instances available
                var commonItems = sortedMagazine.Intersect(sortedNote).ToList();



                return false;

            }



           

        }
    }
}
