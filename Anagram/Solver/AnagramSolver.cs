using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{

    /**
    * Implementation of the Anagram Solver.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    class AnagramSolver
    {
        List<string> possibleWords = new List<string>();
        bool containsIllegalChar = false;
        public string mainWord;
        
        /**
         * 
         * @param mainWord holds the word which we are finding anagrams for.
         */
        public AnagramSolver(string mainWord)
        {
            this.mainWord = mainWord;
            GetWords();
        }

        void GetWords()
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"wordlist.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {

                        foreach (Char c in word)
                        {

                            if (!mainWord.Contains(c))
                            {
                                containsIllegalChar = true;
                                break;
                            }
                            else
                            {
                                containsIllegalChar = false;
                            }

                        }

                        if (containsIllegalChar == false)
                        {
                            possibleWords.Add(word); //if all the chars are correct add it to the list.

                        }
                        else
                        {

                        }

                    }

                }
            }

            GetPairs(possibleWords).ForEach(Console.WriteLine);

        }


        /**
         * 
         * @param possibleWords holds a list of all the words that are of the correct length and alphabet.
         * @return the pairs of words which are of the correct length.
         */

        public List<string> GetPairs(List<string> possibleWords)
        {

            List<string> possiblePairs = new List<string>();
            List<string> Pairs = new List<string>();

            foreach (String firstPossibleWord in possibleWords)
            {
                foreach (String secondPossibleWord in possibleWords)
                {
                    if ((firstPossibleWord.Length + secondPossibleWord.Length) == mainWord.Length)
                    {
                        possiblePairs.Add(firstPossibleWord + ' ' + secondPossibleWord);
                    }
                }
            }


            foreach (String possiblePair in possiblePairs)
            {

                string currentPair = possiblePair;
                string possiblePairNoSpaces = possiblePair.Replace(" ", "");

                char[] ch1 = mainWord.ToCharArray();
                char[] ch2 = possiblePairNoSpaces.ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);

                String val1 = new string(ch1);
                String val2 = new string(ch2);

                

                if (val1 == val2)
                {
                    Pairs.Add(currentPair);
                }

            }

            return Pairs;
        }

    }
}


