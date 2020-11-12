using AnagramSolverAPI.Models;
using AnagramSolverAPI.Services;
using System;
using System.Collections.Generic;

namespace AnagramSolverAPI
{
    /**
    * Anagram solver class.
    *
    * @author Mohammad Danyal
    * @version October 2020
    */

    public class AnagramSolver : IAnagramSolver
    {
        private readonly IWordList _words;
        private readonly IPairCalculator _pairCalculator;

        public AnagramSolver(IWordList words, IPairCalculator pairCalculator)
        {
            _words = words ?? throw new ArgumentNullException(nameof(words));
            _pairCalculator = pairCalculator ?? throw new ArgumentNullException(nameof(pairCalculator));
        }

        public List<Pair> FindAnagrams(string word)
        {
            if (word is null)
            {
                throw new ArgumentNullException(nameof(word));
            }

            var possibleWords = _words.GetWords(word);
            return _pairCalculator.GetPairs(word, possibleWords);
        }
    }
}


