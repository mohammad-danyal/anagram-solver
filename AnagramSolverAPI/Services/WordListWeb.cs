using AnagramSolverAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace AnagramSolverAPI.Services
{
    /**
    * Class which retrieves a word list from a URL comparing it to a given word's properties.
    *
    * @author Mohammad Danyal
    * @version October 2020
    */

    public class WordListWeb : IWordList
    {
        List<string> possibleWords = new List<string>();
        bool containsIllegalChar = false;
        public string mainWord;

        /**
        * 
        * @param mainWord holds the word which we are finding anagrams for.
        */

        public List<string> GetWords(string mainWord, WordContext sc)
        {
            var str = sc.Words.ToList();

            CheckWords(str, mainWord);

            return possibleWords;
        }

        private void CheckWords(List<Word> words, string mainWord)
        {
            foreach (var word in words)
            {

                foreach (var c in word.word)
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

                    possibleWords.Add(word.word);

                }

            }
        }
    }


}
