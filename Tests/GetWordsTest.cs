using System;
using Anagram;
using Anagram.Solver;
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

            Assert.True(0 < possibleWords.GetWords().Count);

        }

        [Fact]
        public void InvalidWordsTest()
        {

            string word = "bcd";

            WordList possibleWords = new WordList(word);

            Assert.True(0 == possibleWords.GetWords().Count);
        }
    }

}
