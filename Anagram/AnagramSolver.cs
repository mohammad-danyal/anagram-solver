using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Anagram.Solver
{

    /**
    * Displays a input messsage.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class AnagramSolver
    {
        public static void FindAnagrams(string word)
        {
            var possibleWords = new WordList(word);
            var pairCalculator = new PairCalculator(possibleWords.GetWords(), word);
            var pairs = pairCalculator.GetPairs(word);

            pairs.ForEach(Console.WriteLine);

            if (pairs.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("No anagrams are possible for your word");
            }
        }
    }
}


