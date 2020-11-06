using AnagramSolverAPI.Models;
using System.Collections.Generic;

namespace AnagramSolverAPI
{
    public interface IAnagramSolver
    {
        List<Pair> FindAnagrams(string word);
    }
}