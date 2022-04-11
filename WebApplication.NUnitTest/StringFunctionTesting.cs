using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.NUnitTest
{
    [TestFixture]
    public class StringFunctionTesting
    {
        private IStringFunction _stringFunction;
        [SetUp]
        public void Setup()
        {
            _stringFunction = new StringFunction();
        }

        #region Test
        [Test]
        [Category("Reverse String")]
        public void ReverseOne_WhenGivingString_ThenReverseIt()
        {
            // Arrange
            string expectedValue = "dammahum";

            // Act
            string actualValue = _stringFunction.ReverseString("muhammad");

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        #endregion

        #region TestCase
        [TestCase("khoirudin", "niduriohk")]
        [TestCase("naskala","alaksan")]
        [TestCase("1234567890","0987654321")]
        public void ReverseTwo_WhenGivingString_ThenReverseIt(string input, string expectedValue)
        {
            // Act
            string actualValue = _stringFunction.ReverseString(input);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        #endregion

        #region TestCaseSource
        [Ignore("TestCase_Reverse3")]
        [TestCaseSource(nameof(SourceProviderCase))]
        public void ReverseThree_WhenGivingString_ThenReverseIt(string input, string expectedValue)
        {
            // Act
            string actualValue = _stringFunction.ReverseString(input);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        public static IEnumerable<object[]> SourceProviderCase()
        {
            yield return new object[] { "or","ro" };
            yield return new object[] { "and", "dna" };
        }
        #endregion
    }
}
