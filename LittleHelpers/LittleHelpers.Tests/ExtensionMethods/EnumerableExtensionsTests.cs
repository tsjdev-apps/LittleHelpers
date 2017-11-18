using System.Collections.ObjectModel;
using System.Linq;
using LittleHelpers.ExtensionMethods;
using LittleHelpers.Tests.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LittleHelpers.Tests.ExtensionMethods
{
    [TestClass]
    public class EnumerableExtensionsTests
    {
        [TestMethod]
        public void EnumerableExtensions_PickRandom_ReturnsOneValue()
        {
            var pickRandomValue = TestList.IntList.PickRandom();

            Assert.AreEqual(typeof(int), pickRandomValue.GetType());
            Assert.IsTrue(TestList.IntList.Contains(pickRandomValue));
        }

        [TestMethod]
        public void EnumerableExtensions_PickRandom_ReturnsProvidedCountValues()
        {
            var pickRandomValues = TestList.IntList.PickRandom(2).ToList();

            Assert.AreEqual(2, pickRandomValues.Count);
            Assert.IsTrue(TestList.IntList.Contains(pickRandomValues[0]));
            Assert.IsTrue(TestList.IntList.Contains(pickRandomValues[1]));
        }


        [TestMethod]
        public void EnumerableExtensions_ToObservableCollection_ReturnsAnObservableCollection()
        {
            var observableCollection = TestList.IntList.ToObservableCollection();

            Assert.AreEqual(typeof(ObservableCollection<int>), observableCollection.GetType());
        }

        [TestMethod]
        public void EnumerableExtensions_HasItems_ReturnsTrueOnNonEmptyList()
        {
            var hasItems = TestList.IntList.HasItems();

            Assert.IsTrue(hasItems);
        }


        [TestMethod]
        public void EnumerableExtensions_HasItems_ReturnsFalseOnEmptyList()
        {
            var hasItems = TestList.EmptyIntList.HasItems();

            Assert.IsFalse(hasItems);
        }
    }
}