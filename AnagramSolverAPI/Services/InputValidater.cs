using System;
using System.Linq;

namespace AnagramSolverAPI.Services
{

    /**
    * Input validation class ensuring input is of the correct format of a word.
    *
    * @author Mohammad Danyal
    * @version September 2020
    */

    public class InputValidater : IInputValidater
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


