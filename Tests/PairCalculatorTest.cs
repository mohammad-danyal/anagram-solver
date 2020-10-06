using System;
using System.Collections.Generic;
using Anagram;
using Anagram.Solver;
using FluentAssertions;
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

            PairCalculator pairCalculator = new PairCalculator(list, mainWord);

            (pairCalculator.GetPairs(mainWord).Count).Should().Be(expected);

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

            PairCalculator pairCalculator = new PairCalculator(list, mainWord);

            (pairCalculator.GetPairs(mainWord).Count).Should().Be(0);

        }
    }

}