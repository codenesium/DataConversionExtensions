using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;
namespace DataConversionExtensionsTests
{
    [TestFixture]
    public class ToFloatTests
    {
        [Test]
        public void ToFloat_NullString_0()
        {
            string testString = null;
            Assert.AreEqual(0, testString.ToFloat());
        }

        [Test]
        public void ToFloat_34534123_34534123()
        {
            string testString = "34534.123";
            Assert.AreEqual((float)34534.123, testString.ToFloat());
        }

        [Test]
        public void ToFloat_ABC123_0()
        {
            string testString = "ABC123";
            Assert.AreEqual(0, testString.ToFloat());
        }

        [Test]
        public void ToNullableFloat_NullString_null()
        {
            string testString = null;
            Assert.AreEqual(null, testString.ToNullableFloat());
        }

        [Test]
        public void ToNullableFloat_ABC123_null()
        {
            string testString = "ABC123";
            Assert.AreEqual(null, testString.ToNullableFloat());
        }

        [Test]
        public void ToNullableFloat_530945690412_530945690412()
        {
            string testString = "5309456904.12";

            Assert.AreEqual((float)5309456904.12, testString.ToNullableFloat());
        }

    }
}
