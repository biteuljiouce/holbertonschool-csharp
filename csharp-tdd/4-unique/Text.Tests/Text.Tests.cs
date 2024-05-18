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
        [TestCase("aazzeertyyy", 6)]
        [TestCase("aazzzeerrtty", 11)]
        [TestCase("azertyyy", 0)]
        [TestCase("aazzeeeerrrtttyy", -1)]
        [TestCase("f", 0)]
        [TestCase("fffffff", -1)]
        [TestCase("", -1)]
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