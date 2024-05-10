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
        /// tests a lot of thing.
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