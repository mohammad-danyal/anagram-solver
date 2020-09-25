using System;
using System.Collections.Generic;
using Anagram;
using Anagram.Solver;
using FluentAssertions;
using Xunit;

namespace GetPairsTest
{
    public class GetPairsTest
    {

        [Theory]
        [InlineData ("aaaccc", "aaa", "ccc", "", "", 1)]
        [InlineData("abcd", "ab", "cd", "ac" , "bd" , 2)]
        public void ValidPairsTest(string mainWord, string firstWord, string secondWord, string thirdWord, string fourthWord, int expected)
        {

            List<string> list = new List<string>()
        {
            firstWord,
            secondWord,
            thirdWord,
            fourthWord,
        };

            PairCalculator pairCalculator = new PairCalculator(list, mainWord);

            (expected == pairCalculator.GetPairs(mainWord).Count).Should().BeTrue();

        }

        [Fact]
        public void InvalidPairsTest()
        {

            string word = "aaa";
            List<string> list = new List<string>()
        {
            "bbb",
            "ccc",
        };

            PairCalculator pairCalculator = new PairCalculator(list, word);

            (0 == pairCalculator.GetPairs(word).Count).Should().BeTrue();

        }
    }

}
