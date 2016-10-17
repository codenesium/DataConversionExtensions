using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;
namespace DataConversionExtentionsTests
{
    [TestFixture]
    public class ToLongTests
    {
        [Test]
        public void ToLong_NullString_0()
        {
            string testString = null;
            Assert.AreEqual(0, testString.ToLong());
        }

        [Test]
        public void ToLong_34534534534534_34534534534534()
        {
            string testString = "34534534534534";
            Assert.AreEqual(34534534534534, testString.ToLong());
        }

        [Test]
        public void ToLong_ABC123_0()
        {
            string testString = "ABC123";
            Assert.AreEqual(0, testString.ToLong());
        }

        [Test]
        public void ToNullableLong_NullString_null()
        {
            string testString = null;
            Assert.AreEqual(null, testString.ToNullableLong());
        }

        [Test]
        public void ToNullableLong_ABC123_null()
        {
            string testString = "ABC123";
            Assert.AreEqual(null, testString.ToNullableLong());
        }

        [Test]
        public void ToNullableLong_123456789012345_123456789012345()
        {
            string testString = "123456789012345";

            Assert.AreEqual(123456789012345, testString.ToNullableLong());
        }

    }
}
