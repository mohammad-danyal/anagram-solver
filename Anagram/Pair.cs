using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Anagram.Solver
{

    /**
    * Class for the pairs of words.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class Pair
    {
        public string firstWord { get; set; }

        public string secondWord { get; set; }

        private string _combinedWord;
        public string combinedWord
        {
            get { return (firstWord + " " + secondWord); }

        }

    }
}


