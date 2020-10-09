using Anagram.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Anagram.Solver
{

    /**
    * Class which works out the appropriate pairs of words.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class PairCalculator : IPairCalculator
    {
        private List<string> possibleWords;

        /**
* 
* @param possibleWords holds a list of all the words that are of the correct length and alphabet.
* @return the pairs of words which are of the correct length.
*/

        public List<Pair> GetPairs(string mainWord, List<string> possibleWords)
        {
            var possiblePairs = (possibleWords.SelectMany(possibleWordOne => possibleWords
            .Where(possibleWordTwo => !(possibleWordOne == possibleWordTwo))
            .Where(possibleWordTwo => (possibleWordOne.Length + possibleWordTwo.Length) == mainWord.Length)
            .Select(possibleWordTwo => new Pair { firstWord = possibleWordOne, secondWord = possibleWordTwo }))).ToList();
            return SortPairs(mainWord, possiblePairs);
        }

        public List<Pair> SortPairs(string mainWord, List<Pair> possiblePairs)
        {

            var Pairs = new List<Pair>();

            char[] ch1 = mainWord.ToCharArray();
            foreach (var possiblePair in possiblePairs)
            {
                var val1 = mainWord.SortAlphabetically();
                var val2 = (possiblePair.firstWord + possiblePair.secondWord).SortAlphabetically();

                if (val1 == val2)
                {
                    Pairs.Add(possiblePair);
                }

            }

            return Pairs;

        }
    }
}


