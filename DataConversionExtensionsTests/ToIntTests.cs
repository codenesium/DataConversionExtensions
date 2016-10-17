using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;

namespace DataConversionExtensionsTests
{
    [TestFixture]
    public class ToIntTests
    {
        [Test]
        public void ToInt_Null_0()
        {
            int? nullInt = null;
            Assert.AreEqual(0, nullInt.ToInt());
        }

        [Test]
        public void ToInt_123_123()
        {
            int? nullInt = 123;
            Assert.AreEqual(123, nullInt.ToInt());
        }

        [Test]
        public void ToNullableInt_Null_0()
        {
            int? nullInt = null;
            Assert.IsNull(nullInt.ToNullableInt());
        }

        [Test]
        public void ToNullableInt_123_123()
        {
            int? nullInt = 123;
            Assert.AreEqual(123, nullInt.ToNullableInt());
        }

        [Test]
        public void ToInt_NullString_0()
        {
            string testString = null;
            Assert.AreEqual(0, testString.ToInt());
        }

        [Test]
        public void ToInt_12345_12345()
        {
            string testString = "12345";
            Assert.AreEqual(12345, testString.ToInt());
        }

        [Test]
        public void ToInt_ABC123_0()
        {
            string testString = "ABC123";
            Assert.AreEqual(0, testString.ToInt());
        }

        [Test]
        public void ToNullableInt_Null_null()
        {
            string testString = null;
            Assert.AreEqual(null, testString.ToNullableInt());
        }

        [Test]
        public void ToNullableInt_ABC123_null()
        {
            string testString = "ABC123";
            Assert.AreEqual(null, testString.ToNullableInt());
        }

        [Test]
        public void ToNullableInt_12345_12345()
        {
            string testString = "12345";
            Assert.AreEqual(12345, testString.ToNullableInt());
        }
    }
}