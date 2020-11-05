using System.Collections.Generic;

namespace AnagramSolverAPI.Services
{
    public interface IWordList
    {
        List<string> GetWords(string mainWord, WordContext sc);
    }
}