using Anagram.Solver;
using Anagram.Solver.Services;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace PairCalculatorTest
{
    public class PairCalculatorTest
    {

        [Theory]
        [InlineData("aaaccc", "aaa", "ccc", "", "", 2)]
        [InlineData("abcd", "ab", "cd", "ac", "bd", 4)]
        public void ValidPairsTest(string mainWord, string possibleWordOne, string possibleWordTwo, string possibleWordThree, string possibleWordFour, int expected)
        {

            List<string> list = new List<string>()
        {
            possibleWordOne,
            possibleWordTwo,
            possibleWordThree,
            possibleWordFour,
        };

            PairCalculator pairCalculator = new PairCalculator();
            var pairs = pairCalculator.GetPairs(mainWord, list);

            (pairs.Count).Should().Be(expected);

        }

        [Theory]
        [InlineData("aaa", "bbb", "ccc")]
        [InlineData("abc", "def", "xyz")]
        public void InvalidPairsTest(string mainWord, string possibleWordOne, string possibleWordTwo)
        {

            List<string> list = new List<string>()
        {
            possibleWordOne,
            possibleWordTwo,
        };

            PairCalculator pairCalculator = new PairCalculator();
            var pairs = pairCalculator.GetPairs(mainWord, list);

            (pairs.Count).Should().Be(0);

        }
    }

}