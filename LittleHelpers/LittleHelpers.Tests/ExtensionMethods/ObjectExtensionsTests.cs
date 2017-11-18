using LittleHelpers.ExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LittleHelpers.Tests.ExtensionMethods
{
    [TestClass]
    public class ObjectExtensionsTests
    {

        [TestMethod]
        public void ObjectExtensions_IsNull_ReturnsTrueIfObjectIsNull()
        {
            object testObject = null;

            var isNull = testObject.IsNull();

            Assert.IsTrue(isNull);
        }


        [TestMethod]
        public void ObjectExtensions_IsNull_ReturnsFalseIfObjectIsNotNull()
        {
            var testObject = new object();

            var isNull = testObject.IsNull();

            Assert.IsFalse(isNull);
        }

        [TestMethod]
        public void ObjectExtensions_IsNotNull_ReturnsFalseIfObjectIsNull()
        {
            object testObject = null;

            var isNull = testObject.IsNotNull();

            Assert.IsFalse(isNull);
        }


        [TestMethod]
        public void ObjectExtensions_IsNotNull_ReturnsTrueIfObjectIsNotNull()
        {
            var testObject = new object();

            var isNull = testObject.IsNotNull();

            Assert.IsTrue(isNull);
        }

        [TestMethod]
        public void ObjectExtensions_AsString_ReturnsStringWithLength0()
        {
            object testObject = null;

            var str = testObject.AsString();

            Assert.IsTrue(str.IsNotNull());
            Assert.AreEqual(typeof(string), str.GetType());
            Assert.AreEqual(0, str.Length);
        }


        [TestMethod]
        public void ObjectExtensions_AsString_ReturnsStringWithLengthGreaterThan0()
        {
            var testObject = new[] { "1", "2" };

            var str = testObject.AsString();

            Assert.IsTrue(str.IsNotNull());
            Assert.AreEqual(typeof(string), str.GetType());
            Assert.IsTrue(str.Length > 0);
        }
    }
}
