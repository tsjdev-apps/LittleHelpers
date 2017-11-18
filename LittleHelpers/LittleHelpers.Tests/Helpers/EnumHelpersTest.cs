using System.Linq;
using LittleHelpers.Helpers;
using LittleHelpers.Tests.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LittleHelpers.Tests.Helpers
{
    [TestClass]
    public class EnumHelpersTest
    {
        [TestMethod]
        public void EnumHelper_GetEnumDefault_ReturnsAsDefaultMarkedValue()
        {
            // act
            var enumValue = EnumHelper.GetEnumDefault<GenderWithDefault>();

            // assert
            Assert.AreEqual(GenderWithDefault.Male, enumValue);
        }

        [TestMethod]
        public void EnumHelper_GetEnumDefault_ReturnsFirstValue()
        {
            // act
            var enumValue = EnumHelper.GetEnumDefault<Gender>();

            // assert
            Assert.AreEqual(Gender.Female, enumValue);
        }

        [TestMethod]
        public void EnumHelper_GetEnumAsEnumarable_ReturnsEnumerableOfEnumValues()
        {
            // act
            var enumValues = EnumHelper.GetEnumAsEnumarable<Gender>().ToList();

            // assert
            Assert.AreEqual(2, enumValues.Count);
            Assert.AreEqual(Gender.Female, enumValues.First());
        }

    }
}
