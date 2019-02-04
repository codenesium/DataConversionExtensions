using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;
namespace DataConversionExtensionsTests
{
    [TestFixture]
    public class ToDoubleTests
    {
        [Test]
        public void ToDouble_NullString_0()
        {
            string testString = null;
            Assert.AreEqual(0, testString.ToDouble());
        }

        [Test]
        public void ToDouble_34534123_34534123()
        {
            string testString = "34534.123";
            Assert.AreEqual(34534.123, testString.ToDouble());
        }

        [Test]
        public void ToDouble_ABC123_0()
        {
            string testString = "ABC123";
            Assert.AreEqual(0, testString.ToDouble());
        }

        [Test]
        public void ToNullableDouble_NullString_null()
        {
            string testString = null;
            Assert.AreEqual(null, testString.ToNullableDouble());
        }

        [Test]
        public void ToNullableDouble_ABC123_null()
        {
            string testString = "ABC123";
            Assert.AreEqual(null, testString.ToNullableDouble());
        }

        [Test]
        public void ToNullableDouble_530945690412_530945690412()
        {
            string testString = "5309456904.12";

            Assert.AreEqual(5309456904.12, testString.ToNullableDouble());
        }

    }
}
