using System;
using NUnit.Framework;
using Codenesium.DataConversionExtensions;
using System.ComponentModel.DataAnnotations;

namespace Codenesium.DataConversionExtensionsTests
{
    [TestFixture]
    public class ObjectGetKey
    {
        [Test]
        public void GetKey_12345_12345()
        {
            KeyTestClass test = new KeyTestClass();
            test.Id = 12345;

            Assert.AreEqual(12345, test.GetKey());
        }
    }


    public class KeyTestClass
    {
        [Key]
        public int Id { get; set; }
    }
}
