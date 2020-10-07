using System.Collections.Generic;

namespace Anagram.Solver
{
    public interface IAnagramSolver
    {
        List<Pair> FindAnagrams(string word);

    }
}