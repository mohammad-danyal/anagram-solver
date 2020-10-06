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

        public List<Pair> GetPairs(string mainWord)
        {
            var possiblePairs = (possibleWords.SelectMany(possibleWordOne => possibleWords
            .Where(possibleWordTwo => !(possibleWordOne == possibleWordTwo))
            .Where(possibleWordTwo => (possibleWordOne.Length + possibleWordTwo.Length) == mainWord.Length)
            .Select(possibleWordTwo => new Pair { firstWord = possibleWordOne, secondWord = possibleWordTwo }))).ToList();
            return SortPairs(mainWord, possiblePairs);
        } 

        public List<Pair> SortPairs(string mainWord, List<Pair> possiblePairs) {

            var Pairs = new List<Pair>();

            foreach (var possiblePair in possiblePairs)
            {

                char[] ch1 = mainWord.ToCharArray();
                char[] ch2 = (possiblePair.firstWord + possiblePair.secondWord).ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);

                var val1 = new string(ch1);
                var val2 = new string(ch2);


                if (val1 == val2)
                {
                    Pairs.Add(possiblePair);
                }

            }

            return Pairs;
        }

    }
}


