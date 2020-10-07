using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Anagram.Solver
{

    /**
    * Anagram solver class.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class AnagramSolver : IAnagramSolver
    {
        public List<Pair> FindAnagrams(string word)
        {
            var possibleWords = new WordList(word);
            var pairCalculator = new PairCalculator(possibleWords.GetWords(), word);
            var pairs = pairCalculator.GetPairs(word);

            return pairs;
        }
    }
}


