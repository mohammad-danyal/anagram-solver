using System.Collections.Generic;
using AnagramSolverAPI.Models;

namespace AnagramSolverAPI.Services
{
    public interface IPairCalculator
    {
        List<Pair> GetPairs(string mainWord, List<string> possibleWords);
        List<Pair> SortPairs(string mainWord, List<Pair> possiblePairs);
    }
}