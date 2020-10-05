using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Anagram.Solver
{
    /**
    * Class which reads through a word list comparing it to a given word's properties.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class WordList
    {
        List<string> possibleWords = new List<string>();
        bool containsIllegalChar = false;
        public string mainWord;

        /**
        * 
        * @param mainWord holds the word which we are finding anagrams for.
        */
        public WordList(string mainWord)
        {
            this.mainWord = mainWord;;
        }

        public List<string> GetWords()
        {

            //refactor
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Users\danya\Desktop\anagram-solver\wordlist.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split(' ');
                    foreach (var word in words)
                    {

                        foreach (var c in word)
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

                    }

                }
            }

            return possibleWords;
        } 

    }


}
