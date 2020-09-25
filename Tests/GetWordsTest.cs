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

            WordList possibleWords = new WordList(word);

            (possibleWords.GetWords().Count).Should().BeGreaterThan(0);

        }

        [Fact]
        public void InvalidWordsTest()
        {

            string word = "bcd";

            WordList possibleWords = new WordList(word);

            (possibleWords.GetWords().Count).Should().BeGreaterThan(0);
        }
    }

}
