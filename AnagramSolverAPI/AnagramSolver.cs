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
    * @version September 2020
    */

    public class AnagramSolver : IAnagramSolver
    {
        private readonly IWordList _words;
        private readonly IPairCalculator _pairCalculator;

        private WordContext wordContext;

        public AnagramSolver(IWordList words, IPairCalculator pairCalculator, WordContext sc)
        {
            _words = words ?? throw new ArgumentNullException(nameof(words));
            this._pairCalculator = pairCalculator ?? throw new ArgumentNullException(nameof(pairCalculator));

            wordContext = sc;
        }

        public List<Pair> FindAnagrams(string word)
        {
            var possibleWords = _words.GetWords(word, wordContext);

            return _pairCalculator.GetPairs(word, possibleWords);
        }
    }
}


