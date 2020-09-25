using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram.Solver
{

    /**
    * Class which works out the appropriate pairs of words.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    class PairCalculator
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

            List<string> possiblePairs = new List<string>();
            List<string> Pairs = new List<string>();

            foreach (String firstPossibleWord in possibleWords)
            {
                foreach (String secondPossibleWord in possibleWords)
                {
                    if ((firstPossibleWord.Length + secondPossibleWord.Length) == mainWord.Length)
                    {
                        possiblePairs.Add(firstPossibleWord + ' ' + secondPossibleWord);
                    }
                }
            }


            foreach (String possiblePair in possiblePairs)
            {

                string currentPair = possiblePair;
                string possiblePairNoSpaces = possiblePair.Replace(" ", "");

                char[] ch1 = mainWord.ToCharArray();
                char[] ch2 = possiblePairNoSpaces.ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);

                String val1 = new string(ch1);
                String val2 = new string(ch2);



                if (val1 == val2)
                {
                    Pairs.Add(currentPair);
                }

            }

            return Pairs;
        }

    }
}

