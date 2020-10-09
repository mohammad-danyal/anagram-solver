using System;
using System.Collections.Generic;
using System.Linq;
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

    public class WordList : IWordList
    {
        List<string> possibleWords = new List<string>();
        bool containsIllegalChar = false;
        public string mainWord;

        /**
        * 
        * @param mainWord holds the word which we are finding anagrams for.
        */

        public List<string> GetWords(string mainWord)
        {

            using (System.IO.StreamReader sr = new System.IO.StreamReader(Reader.GetFile()))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    string[] words = line.Split(' ');
                    CheckWords(words, mainWord);
                }
            }

            return possibleWords;
        }

        private void CheckWords(string[] words, string mainWord)
        {
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
                    possibleWords.Add(word);

                }

            }
        }
    }


}
