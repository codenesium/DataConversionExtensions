using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;

namespace DataConversionExtensionsTests
{
    [TestFixture]
    public class ToTimespanTests
    {
        [Test]
        public void ToTimespan_Null_DefaultTimespan()
        {
            string testString = null;
            Assert.AreEqual(default(TimeSpan),testString.ToTimespan());
        }

        [Test]
        public void ToTimespan_Timespan_Timespan()
        {
			TimeSpan timespan = new TimeSpan(1, 1, 1);
			Assert.AreEqual(timespan, timespan.ToTimespan());
		}

        [Test]
        public void ToTimespan_InvalidString_False()
        {
            string testString = "InvalidString";
			Assert.AreEqual(default(TimeSpan), testString.ToTimespan());
		}

        [Test]
        public void ToNullableTimespan_null_null()
        {
            string testString = null;
            Assert.IsNull(testString.ToNullableTimespan());
        }

        [Test]
        public void ToNullableTimespan_NotNull_NotNull()
        {
			TimeSpan timespan = new TimeSpan(1, 1, 1);
			Assert.AreEqual(timespan, timespan.ToTimespan());
		}

        [Test]
        public void ToNullableTimespan_invalidString_null()
        {
            string testString = "InvalidString";
            Assert.IsNull(testString.ToNullableTimespan());
        }
    }
}