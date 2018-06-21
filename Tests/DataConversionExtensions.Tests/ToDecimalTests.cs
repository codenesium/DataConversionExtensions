using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;
namespace DataConversionExtensionsTests
{
    [TestFixture]
    public class ToDecimalTests
    {
        [Test]
        public void ToDecimal_NullString_0()
        {
            string testString = null;
            Assert.AreEqual(0, testString.ToDecimal());
        }

        [Test]
        public void ToDecimal_34534123_34534123()
        {
            string testString = "34534.123";
            Assert.AreEqual(34534.123, testString.ToDecimal());
        }

        [Test]
        public void ToDecimal_ABC123_0()
        {
            string testString = "ABC123";
            Assert.AreEqual(0, testString.ToDecimal());
        }

        [Test]
        public void ToNullableDecimal_NullString_null()
        {
            string testString = null;
            Assert.AreEqual(null, testString.ToNullableDecimal());
        }

        [Test]
        public void ToNullableDecimal_ABC123_null()
        {
            string testString = "ABC123";
            Assert.AreEqual(null, testString.ToNullableDecimal());
        }

        [Test]
        public void ToNullableDecimal_530945690412_530945690412()
        {
            string testString = "5309456904.12";

            Assert.AreEqual(5309456904.12, testString.ToNullableDecimal());
        }

    }
}
