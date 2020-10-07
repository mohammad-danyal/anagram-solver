using Anagram.Solver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    class Factory
    {
        public static IAnagramSolver CreateSolver()
        {
            return new AnagramSolver();
        }

        public static IInputValidater CreateValidater()
        {
            return new InputValidater();
        }

    }
}
