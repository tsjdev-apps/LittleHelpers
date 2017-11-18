using System;
using LittleHelpers.ExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LittleHelpers.Tests.ExtensionMethods
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void DateTimeExtensions_ToUnixTimestamp_ReturnsCorrectValueFor01011970()
        {
            var dateTime = new DateTime(1970, 1, 1);

            var unixTimeStamp = dateTime.ToUnixTimestamp();

            Assert.AreEqual(0, unixTimeStamp);
        }

        [TestMethod]
        public void DateTimeExtensions_ToUnixTimestamp_ReturnsCorrectValueFor01011971()
        {
            var dateTime = new DateTime(1971, 1, 1);

            var unixTimeStamp = dateTime.ToUnixTimestamp();

            Assert.AreEqual(31536000, unixTimeStamp);
        }
    }
}
