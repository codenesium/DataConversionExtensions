using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;

namespace DataConversionExtentionsTests
{
    [TestFixture]
    public class ToBooleanTests
    {
        [Test]
        public void ToBoolean_Null_False()
        {
            string testString = null;
            Assert.IsFalse(testString.ToBoolean());
        }

        [Test]
        public void ToBoolean_False_False()
        {
            string testString = "False";
            Assert.IsFalse(testString.ToBoolean());
        }

        [Test]
        public void ToBoolean_True_True()
        {
            string testString = "True";
            Assert.IsTrue(testString.ToBoolean());
        }

        [Test]
        public void ToBoolean_InvalidString_False()
        {
            string testString = "InvalidString";
            Assert.IsFalse(testString.ToBoolean());
        }

        [Test]
        public void ToNullableBoolean_null_null()
        {
            string testString = null;
            Assert.IsNull(testString.ToNullableBoolean());
        }

        [Test]
        public void ToNullableBoolean_false_False()
        {
            string testString = "False";
            Assert.IsFalse((bool)testString.ToNullableBoolean());
        }

        [Test]
        public void ToNullableBoolean_true_true()
        {
            string testString = "True";
            Assert.IsTrue((bool)testString.ToNullableBoolean());
        }

        [Test]
        public void ToNullableBoolean_invalidString_null()
        {
            string testString = "InvalidString";
            Assert.IsNull(testString.ToNullableBoolean());
        }
    }
}