using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Anagram.Solver
{
    public interface IAnagramSolver
    {
        List<Pair> FindAnagrams(string word, ServiceProvider serviceProvider);

    }
}