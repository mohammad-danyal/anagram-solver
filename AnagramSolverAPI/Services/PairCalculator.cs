using AnagramSolverAPI.Extensions;
using AnagramSolverAPI.Models;
using AnagramSolverAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Solver.Services
{

    /**
    * Class which works out the appropriate pairs of words.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class PairCalculator : IPairCalculator
    {
        /**
        * 
        * @param possibleWords holds a list of all the words that are of the correct length and alphabet.
        * @return the pairs of words which are of the correct length.
*/
        public List<Pair> GetPairs(string mainWord, List<string> possibleWords)
        {
            if (mainWord is null)
            {
                throw new ArgumentNullException(nameof(mainWord));
            }

            if (possibleWords is null)
            {
                throw new ArgumentNullException(nameof(possibleWords));
            }
            var possiblePairs = (possibleWords.SelectMany(possibleWordOne => possibleWords
            .Where(possibleWordTwo => !(possibleWordOne == possibleWordTwo))
            .Where(possibleWordTwo => (possibleWordOne.Length + possibleWordTwo.Length) == mainWord.Length)
            .Select(possibleWordTwo => new Pair
            {
                firstWord = possibleWordOne,
                secondWord = possibleWordTwo
            }))).ToList();
            return SortPairs(mainWord, possiblePairs);
        }

        public List<Pair> SortPairs(string mainWord, List<Pair> possiblePairs)
        {
            if (mainWord is null)
            {
                throw new ArgumentNullException(nameof(mainWord));
            }

            if (possiblePairs is null)
            {
                throw new ArgumentNullException(nameof(possiblePairs));
            }

            var Pairs = new List<Pair>();

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