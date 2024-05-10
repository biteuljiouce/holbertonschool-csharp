using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>
    /// Tests class Text.Str
    /// </summary>
    public class StrTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void no_repeating_returns_n1()
        {
            // Arrange
            string str = "azerty";
            int correctIndex = -1;
            // Act
            int result = Str.UniqueChar(str);
            // Assert
            Assert.AreEqual(correctIndex, result);
        }
        /// <summary>
        /// test
        /// </summary>
        [TestCase("azeertyyy", 2)]
        [TestCase("azertyyy", 5)]
        [TestCase("aazertyyy", 0)]
        [TestCase("azerty", -1)]
        [TestCase("f", -1)]
        public void many_tests(string str, int correctIndex)
        {
            // Arrange
            // Act
            int result = Str.UniqueChar(str);
            // Assert
            Assert.AreEqual(correctIndex, result);
        }
    }
}