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

    public class PairCalculator
    {
        private List<string> possibleWords;

        /**
* 
* @param possibleWords holds a list of all the words that are of the correct length and alphabet.
* @return the pairs of words which are of the correct length.
*/
        public PairCalculator(List<string> possibleWords, string mainWord)
        {
            this.possibleWords = possibleWords;
            GetPairs(mainWord);
        }

        public List<string> GetPairs(string mainWord)
        {
            var possiblePairs = (possibleWords.SelectMany(possibleWord1 => possibleWords
            .Where(possibleWord2 => !(possibleWord1 == possibleWord2))
            .Where(possibleWord2 => (possibleWord1.Length + possibleWord2.Length) == mainWord.Length)
            .Select(possibleWord2 => possibleWord1 + ' ' + possibleWord2))).ToList();
            return SortPairs(mainWord, possiblePairs);
        } 

        public List<string> SortPairs(string mainWord, List<string> possiblePairs) {

            var Pairs = new List<string>();

            foreach (var possiblePair in possiblePairs)
            {

                var currentPair = possiblePair;
                var possiblePairNoSpaces = possiblePair.Replace(" ", "");

                char[] ch1 = mainWord.ToCharArray();
                char[] ch2 = possiblePairNoSpaces.ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);

                var val1 = new string(ch1);
                var val2 = new string(ch2);

                //new class for possible pairings

                if (val1 == val2)
                {
                    Pairs.Add(currentPair);
                }

            }

            return Pairs;
        }

    }
}


