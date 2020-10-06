using System;
using Anagram;
using Anagram.Solver;
using FluentAssertions;
using Xunit;

namespace InputValidaterTest
{
    public class InputValidaterTest
    {

        [Theory]
        [InlineData("blue")]
        [InlineData("Yellow")]
        [InlineData("greEn")]
        public void ValidInputTest(string input)
        {

            InputValidater inputvalidate = new InputValidater();

           inputvalidate.IsInputValid(input).Should().Be(true);
        }

        [Theory]
        [InlineData("blu3")]
        [InlineData("Yell0w!")]
        [InlineData("gree/n")]
        public void InvalidInputTest(string input)
        {

            InputValidater inputvalidate = new InputValidater();

            inputvalidate.IsInputValid(input).Should().Be(false);

        }

    }

}