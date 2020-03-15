using ET_5_NumberToText.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests.DataTests
{
    public class ParserTests
    {
        [Fact]
        public void Parse_Null_NullReferenceException()
        {
            //arrange
            string[] args = null;

            //act

            //assert
            Assert.Throws<NullReferenceException>(() => Parser.Parse(args));
        }
        [Fact]
        public void Parse_IncorrectCountParams_ArgumentException()
        {
            //arrange
            string[] args = new string[InputData.CountParams + 1];

            //act

            //assert
            Assert.Throws<ArgumentException>(() => Parser.Parse(args));
        }
        [Fact]
        public void Parse_EmptyArr_ArgumentNullException()
        {
            //arrange
            string[] args = new string[InputData.CountParams];

            //act

            //assert
            Assert.Throws<ArgumentNullException>(() => Parser.Parse(args));
        }

        [Fact]
        public void Parse_IncorrectNumber_FormatException()
        {
            //arrange
            string[] args = new string[InputData.CountParams]
                { "dsa", InputData.Algorithms.English.ToString()};

            //act

            //assert
            Assert.Throws<FormatException>(() => Parser.Parse(args));
        }
        [Fact]
        public void Parse_IncorrectAlgorithm_ArgumentException()
        {
            //arrange
            string[] args = new string[InputData.CountParams]
                { "123", "dsaasd"};

            //act

            //assert
            Assert.Throws<ArgumentException>(() => Parser.Parse(args));
        }


        [Fact]
        public void Parse_AllCorrect_CorrectNumber()
        {
            //arrange
            string[] args = new string[InputData.CountParams]
                { "123", InputData.Algorithms.English.ToString()};
            var expected = 123;

            //act
            var actual = Parser.Parse(args);

            //assert
            Assert.Equal(expected, actual.Number);
        }

        [Fact]
        public void Parse_AllCorrect_CorrectAlgorithm()
        {
            //arrange
            string[] args = new string[InputData.CountParams]
                { "123", InputData.Algorithms.English.ToString()};
            var expected = InputData.Algorithms.English;

            //act
            var actual = Parser.Parse(args);

            //assert
            Assert.Equal(expected, actual.Algorithm);
        }
    }
}
