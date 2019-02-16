using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;
using System.ComponentModel.DataAnnotations;

namespace Codenesium.DataConversionExtensionsTests
{
    [TestFixture]
    public class ToDateTimeTest
    {
        [Test]
        public void ToCompleteDateString()
        {
            DateTime date = DateTime.Parse("06/18/2016 19:39:29.050");
            Assert.AreEqual("06/18/2016 19:39:29.050", date.ToCompleteDateString());
        }

        [Test]
        public void ToDateTime_20160301()
        {
            DateTime date = DateTime.Parse("06/18/2016 19:39:29.050");
            Assert.AreEqual(date, ("06/18/2016 19:39:29.050").ToDateTime());
        }

        [Test]
        public void ToDateTime_empty()
        {
            Assert.AreEqual(DateTime.MinValue, ("").ToDateTime());
        }

        [Test]
        public void ToNullableDateTime_20160301()
        {
            DateTime date = DateTime.Parse("06/18/2016 19:39:29.050");
            Assert.AreEqual(date, ("06/18/2016 19:39:29.050").ToNullableDateTime());
        }

        [Test]
        public void ToNullableDateTime_empty()
        {
            Assert.IsNull(("").ToNullableDateTime());
        }
    }
}