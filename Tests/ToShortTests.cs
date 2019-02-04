using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;
namespace DataConversionExtensionsTests
{
    [TestFixture]
    public class ToShortTests
    {
        [Test]
        public void ToShort_NullString_0()
        {
            string testString = null;
            Assert.AreEqual(0, testString.ToShort());
        }

        [Test]
        public void ToShort_123_123()
        {
            string testString = "123";
            Assert.AreEqual(123, testString.ToShort());
        }

        [Test]
        public void ToShort_ABC123_0()
        {
            string testString = "ABC123";
            Assert.AreEqual(0, testString.ToShort());
        }

        [Test]
        public void ToNullableShort_NullString_null()
        {
            string testString = null;
            Assert.AreEqual(null, testString.ToNullableShort());
        }

        [Test]
        public void ToNullableShort_ABC123_null()
        {
            string testString = "ABC123";
            Assert.AreEqual(null, testString.ToNullableShort());
        }

        [Test]
        public void ToNullableShort_123_123()
        {
            string testString = "123";

            Assert.AreEqual(123, testString.ToNullableShort());
        }

    }
}
