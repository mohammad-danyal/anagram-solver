using System;
using Anagram;
using Anagram.Solver;
using Xunit;

namespace GetWordsTest
{
    public class InputTest
    {

        [Theory]
        [InlineData("blue")]
        [InlineData("Yellow")]
        [InlineData("greEn")]
        public void ValidInputTest(string input)
        {

            InputValidater inputvalidate = new InputValidater();

            Assert.True(inputvalidate.IsInputValid(input));

        }

        [Theory]
        [InlineData("blu3")]
        [InlineData("Yell0w!")]
        [InlineData("gree/n")]
        public void InvalidInputTest(string input)
        {

            InputValidater inputvalidate = new InputValidater();

            Assert.False(inputvalidate.IsInputValid(input));

        }


    }

}
