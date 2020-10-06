using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Anagram.Solver
{

    /**
    * Input validation class ensuring input is of the correct format of a word.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class InputValidater
    {
        public bool IsInputValid(string input)
        {
            return (IsAllLetters(input));
        }

        static bool IsAllLetters(string s)
        {
            return (s.All(Char.IsLetter));
        }

    }
}


