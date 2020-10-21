using System;
using Anagram;
using Anagram.Solver;
using FluentAssertions;
using Xunit;

namespace GetWordsTest
{
    public class GetWordsTest
    {

        [Fact]
        public void ValidWordsTest()
        {

            string word = "blue";

            WordListWeb possibleWords = new WordListWeb();

            (possibleWords.GetWords(word).Count).Should().BeGreaterThan(0);

        }

        [Fact]
        public void InvalidWordsTest()
        {

            string word = "bcd";

            WordListWeb possibleWords = new WordListWeb();

            (possibleWords.GetWords(word).Count).Should().Be(0);
        }
    }

}