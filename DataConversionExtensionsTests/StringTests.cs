using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;
using System.ComponentModel.DataAnnotations;

namespace Codenesium.DataConversionExtensionsTests
{
    [TestFixture]
    public class StringTest
    {
        [Test]
        public void ToUpperCaseFirstLetter()
        {
            var value = "testing";
            var result = value.ToUpperCaseFirstLetter();
            Assert.IsTrue(result == "Testing");
        }

        [Test]
        public void ToUpperCaseFirstLetterArgException()
        {
            var value = "";
            try
            {
                var result = value.ToUpperCaseFirstLetter();
                Assert.Fail();
            }
            catch(ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void ToUpperCaseFirstLetterStringStartsWithDigit()
        {
            var value = "619test";
            var result = value.ToUpperCaseFirstLetter();
            Assert.IsTrue(result == "619Test");
        }

        [Test]
        public void ToUpperCaseFirstLetterSingleLetter()
        {
            var value = "t";
            var result = value.ToUpperCaseFirstLetter();
            Assert.IsTrue(result == "T");
        }

        [Test]
        public void ToUpperCaseFirstLetterSingleDigit()
        {
            var value = "9";
            var result = value.ToUpperCaseFirstLetter();
            Assert.IsTrue(result == "9");
        }

        [Test]
        public void ToUpperCaseFirstLetterOnlyDigits()
        {
            var value = "911";
            var result = value.ToUpperCaseFirstLetter();
            Assert.IsTrue(result == "911");
        }


        [Test]
        public void ToLowerCaseFirstLetter()
        {
            var value = "Testing";
            var result = value.ToLowerCaseFirstLetter();
            Assert.IsTrue(result == "testing");
        }

        [Test]
        public void ToLowerCaseFirstLetterSingleLetter()
        {
            var value = "T";
            var result = value.ToLowerCaseFirstLetter();
            Assert.IsTrue(result == "t");
        }

        [Test]
        public void ToLowerCaseFirstLetterONlyDigits()
        {
            var value = "911";
            var result = value.ToLowerCaseFirstLetter();
            Assert.IsTrue(result == "911");
        }

        [Test]
        public void ToLowerCaseFirstLetterSingleDigit()
        {
            var value = "6";
            var result = value.ToLowerCaseFirstLetter();
            Assert.IsTrue(result == "6");
        }



        [Test]
        public void ToLowerCaseFirstLetterStringStartsWithDigit()
        {
            var value = "123Test";
            var result = value.ToLowerCaseFirstLetter();
            Assert.IsTrue(result == "123test");
        }

        [Test]
        public void ToLowerCaseFirstLetterArgException()
        {
            var value = "";
            try
            {
                var result = value.ToLowerCaseFirstLetter();
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void ToIndexOfFirstLetterFirstLetterIsChar()
        {
            var value = "test9";
            var result = value.IndexOfFirstLetter();
            Assert.IsTrue(result == 0);

        }

        [Test]
        public void ToIndexOfFirstLetterFirstLetterIsNumber()
        {
            var value = "213";
            var result = value.IndexOfFirstLetter();
            Assert.IsTrue(result == -1);

        }

        [Test]
        public void ToIndexOfFirstLetter()
        {
            var value = "123Test";
            var result = value.IndexOfFirstLetter();
            Assert.IsTrue(result == 3);

        }

        [Test]
        public void RemoveTrailingSlash()
        {
            var value = "test\\";
            var result = value.RemoveTrailingSlash();
            Assert.IsTrue(result == "test");

        }

        [Test]
        public void RemoveTrailingSlash2()
        {
            var value = "test/";
            var result = value.RemoveTrailingSlash();
            Assert.IsTrue(result == "test");

        }

        [Test]
        public void RemoveTrailingSlash3()
        {
            var value = @"test/";
            var result = value.RemoveTrailingSlash();
            Assert.IsTrue(result == "test");

        }
        [Test]
        public void RemoveTrailingSlash4()
        {
            var value = @"test\";
            var result = value.RemoveTrailingSlash();
            Assert.IsTrue(result == "test");
        }



        [Test]
        public void RemoveLeadingSlash()
        {
            var value = "/test";
            var result = value.RemoveLeadingSlash();
            Assert.IsTrue(result == "test");

        }

          [Test]
        public void RemoveLeadingSlash2()
        {
            var value = @"\test";
            var result = value.RemoveLeadingSlash();
            Assert.IsTrue(result == "test");
        }

   /*     [Test]
        public void RemoveLeadingSlash3()
        {
            var value = "\best";
            var result = value.RemoveLeadingSlash();
            Assert.IsTrue(result == "best");
        }
        */

    }
}