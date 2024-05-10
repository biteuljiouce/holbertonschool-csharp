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
        [TestCase("camelCase", 2)]
        [TestCase("azertyyy", 1)]
        [TestCase("", 0)]
        [TestCase(" ", 0)]
        [TestCase("camelCase TamelCase", 4)]
        [TestCase("camel321456Case666TamelCase", 4)]
        public void many_tests(string str, int nbOfWord)
        {
            // Arrange
            // Act
            int result = Str.CamelCase(str);
            // Assert
            Assert.AreEqual(nbOfWord, result);
        }
    }
}