using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

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
        public List<Pair> FindAnagrams(string word, ServiceProvider serviceProvider)
        {
            var words = serviceProvider.GetService<IWordList>();
            var possibleWords = words.GetWords(word);

            var pairCalculator = serviceProvider.GetService<IPairCalculator>();

            var pairs = pairCalculator.GetPairs(word, possibleWords);

            return pairs;
        }
    }
}


