using LittleHelpers.ExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LittleHelpers.Tests.ExtensionMethods
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void StringExtensions_IsNullOrEmpty_ReturnsTrueIfStringIsNull()
        {
            string testString = null;

            var isNull = testString.IsNullOrEmpty();

            Assert.IsTrue(isNull);
        }


        [TestMethod]
        public void StringExtensions_IsNullOrEmpty_ReturnsFalseIfStringIsNotNull()
        {
            const string testString = "Test String";

            var isNull = testString.IsNullOrEmpty();

            Assert.IsFalse(isNull);
        }

        [TestMethod]
        public void StringExtensions_IsNeitherNullNorEmpty_ReturnsFalseIfStringIsNull()
        {
            string testString = null;

            var isNull = testString.IsNeitherNullNorEmpty();

            Assert.IsFalse(isNull);
        }


        [TestMethod]
        public void StringExtensions_IsNeitherNullNorEmpty_ReturnsTrueIfStringIsNotNull()
        {
            const string testString = "Test String";

            var isNull = testString.IsNeitherNullNorEmpty();

            Assert.IsTrue(isNull);
        }
    }
}