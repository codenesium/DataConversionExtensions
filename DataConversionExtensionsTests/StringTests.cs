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
        public void ToLowerCaseFirstLetter()
        {
            var value = "Testing";
            var result = value.ToLowerCaseFirstLetter();
            Assert.IsTrue(result == "testing");
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

        [Test]
        public void RemoveLeadingSlash3()
        {
            var value = "\best";
            var result = value.RemoveLeadingSlash();
            Assert.IsTrue(result == "best");
        }


    }
}