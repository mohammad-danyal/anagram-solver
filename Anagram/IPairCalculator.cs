using System.Collections.Generic;

namespace Anagram.Solver
{
    public interface IPairCalculator
    {
        List<Pair> GetPairs(string mainWord, List<string> possibleWords);
        List<Pair> SortPairs(string mainWord, List<Pair> possiblePairs);
    }
}