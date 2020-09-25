using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram.Solver
{

    /**
    * Displays a input messsage.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class InputValidater
    {
        private string input;

        public bool IsInputValid(string input)
        {

            this.input = input;

            if (IsAllLetters(input))
            {
                return true;
                } else
            {
                return false;
            }
        }


        static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

    }

    
}


