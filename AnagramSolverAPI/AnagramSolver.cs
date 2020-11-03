﻿using System;
using System.Collections.Generic;
using AnagramSolverAPI.Services;
using AnagramSolverAPI.Models;

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

        public AnagramSolver(IWordList words, IPairCalculator pairCalculator)
        {
            _words = words ?? throw new ArgumentNullException(nameof(words));
            this._pairCalculator = pairCalculator ?? throw new ArgumentNullException(nameof(pairCalculator));
        }

        public List<Pair> FindAnagrams(string word)
        {
            var possibleWords = _words.GetWords(word);

            return _pairCalculator.GetPairs(word, possibleWords);
        }
    }
}

