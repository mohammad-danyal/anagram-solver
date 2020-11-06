using AnagramSolverAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnagramSolverAPI.Services
{
    /**
    * Implementation of a database word list.
    *
    * @author Mohammad Danyal
    * @version October 2020
    */

    public class WordListDB : IWordList
    {
        List<string> possibleWords = new List<string>();
        bool containsIllegalChar = false;
        public string mainWord;
        private readonly WordContext _wordContext;

        public WordListDB(WordContext wordContext)
        {
            _wordContext = wordContext;
        }

        /**
        * 
        * @param mainWord holds the word which we are finding anagrams for.
        */

        public List<string> GetWords(string mainWord)
        {
            var str = _wordContext.Words.ToList();

            CheckWords(str, mainWord);

            return possibleWords;
        }

        private void CheckWords(List<WordModel> words, string mainWord)
        {
            foreach (var word in words)
            {

                foreach (var c in word.Word)
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

                    possibleWords.Add(word.Word);

                }

            }
        }
    }


}
