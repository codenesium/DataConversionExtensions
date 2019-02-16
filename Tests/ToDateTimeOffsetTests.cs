using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;
using System.ComponentModel.DataAnnotations;

namespace Codenesium.DataConversionExtensionsTests
{
    [TestFixture]
    public class ToDateTimeOffsetTest
    {

        [Test]
        public void ToDateTimeOffset_20160301()
        {
			DateTimeOffset date = DateTime.Parse("06/18/2016 19:39:29.050");
            Assert.AreEqual(date, ("06/18/2016 19:39:29.050").ToDateTimeOffset());
        }

        [Test]
        public void ToDateTimeOffset_empty()
        {
            Assert.AreEqual(DateTimeOffset.MinValue, ("").ToDateTimeOffset());
        }

        [Test]
        public void ToNullableDateTimeOffset_20160301()
        {
			DateTimeOffset date = DateTime.Parse("06/18/2016 19:39:29.050");
            Assert.AreEqual(date, ("06/18/2016 19:39:29.050").ToNullableDateTimeOffset());
        }

        [Test]
        public void ToNullableDateTimeOffset_empty()
        {
            Assert.IsNull(("").ToNullableDateTime());
        }
    }
}