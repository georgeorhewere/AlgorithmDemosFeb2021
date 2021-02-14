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
            //get items not available in the magazine list
            var exceptItems = note.Except(magazine).ToList();
            
            if (exceptItems.Any())
            {
                Console.WriteLine("Cannot form note");
                return false;
            }
            else
            {
                Console.WriteLine("Process note");
                bool isProperlyFormedNote = false;
                // checked intersection to determine the instances available
                var commonItems = magazine.Intersect(note).ToList();
                if (commonItems.Count.Equals(note.Count()))
                {
                    isProperlyFormedNote = true;
                }
                else
                {
                    // check duplicate items in list 
                    Console.WriteLine("Check duplicate items in note");
                    var watch = new System.Diagnostics.Stopwatch();
                    //watch.Start();
                    //var itemsWithMoreThanOneInstance = note.Where(x => note.ToList().FindAll(t => t.Equals(x)).Count > 1).ToList();
                    //watch.Stop();
                    Console.WriteLine($"time taken to find instances where {watch.ElapsedMilliseconds }");
                    watch.Reset();

                    watch.Start();
                    var itemsWithMoreThanOneInstanceLinq = note.GroupBy(x => x).Where(g => g.Count() > 1).ToDictionary(x => x.Key, y => y.Count());
                    watch.Stop();

                    Console.WriteLine($"time taken to find instances Linq {watch.ElapsedMilliseconds }");
                    watch.Reset();

                   // Console.WriteLine($"Distinct Item Count {itemsWithMoreThanOneInstance.Distinct().Count()}");
                    watch.Start();
                    foreach (var item in itemsWithMoreThanOneInstanceLinq)
                    {
                        int itemCountInMagazine = magazine.ToList().FindAll(word => word.Equals(item.Key)).Count;
                        //magazine.Where(x => x.Equals(item.Key)).Count();
                        if ( itemCountInMagazine > 1)
                        {                            
                            isProperlyFormedNote = itemCountInMagazine >= item.Value;
                            Console.WriteLine($"Find {item.Value } instance count of { item } in magazine");
                            if (!isProperlyFormedNote)
                                break;

                        }
                        else
                        {
                            isProperlyFormedNote = false;
                            break;
                        }
                    }
                    watch.Stop();
                    Console.WriteLine($"time taken to determine properly formed note  {watch.ElapsedMilliseconds }");

                }

                return isProperlyFormedNote;                

            }
           

        }
    }
}
