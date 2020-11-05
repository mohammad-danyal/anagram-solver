using AnagramSolverAPI.Models;
using System.Collections.Generic;

namespace AnagramSolverAPI.Services
{
    public interface IPairCalculator
    {
        List<Pair> GetPairs(string mainWord, List<string> possibleWords);
        List<Pair> SortPairs(string mainWord, List<Pair> possiblePairs);
    }
}