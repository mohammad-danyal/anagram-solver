using System;
using Anagram;
using Anagram.Solver;
using FluentAssertions;
using Xunit;

namespace AnagramSolverTest
{
    public class AnagramSolverTest
    {

        [Theory]
        [InlineData("bluerabbit", 176)]

        public void CheckNumberOfAnagrams(string mainWord, int numberOfAnagramsExpected)
        {
            var pairs = AnagramSolver.FindAnagrams(mainWord);
            
            (pairs.Count).Should().Be(numberOfAnagramsExpected);
        }

        
    }

}