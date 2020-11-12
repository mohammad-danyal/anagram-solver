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
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            return (IsAllLetters(input));
        }

        public static bool IsAllLetters(string s)
        {
            if (s is null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            return (s.All(Char.IsLetter));
        }
    }
}


