using AnagramSolverAPI.Models;
using System;
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
        private readonly WordContext _wordContext;

        public WordListDB(WordContext wordContext)
        {
            _wordContext = wordContext ?? throw new ArgumentNullException(nameof(wordContext));
        }

        /**
        * 
        * @param mainWord holds the word which we are finding anagrams for.
        */

        public List<string> GetWords(string mainWord)
        {
            if (mainWord is null)
            {
                throw new ArgumentNullException(nameof(mainWord));
            }

            List<string> possibleWords = new List<string>();
            var str = _wordContext.Words.ToList();

            CheckWords(str, mainWord, possibleWords);

            return possibleWords;
        }

        private void CheckWords(List<WordModel> words, string mainWord, List<string> possibleWords)
        {
            bool containsIllegalChar = false;
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
