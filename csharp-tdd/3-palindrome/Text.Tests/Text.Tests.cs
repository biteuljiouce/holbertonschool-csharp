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
        public void isNotPalidrome()
        {
            // Arrange
            string input = "hello";
            // Act

            // Assert
            Assert.IsFalse(Str.IsPalindrome(input));
        }
        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void isPalidrome()
        {
            // Arrange
            string input = "helleh";
            // Act

            // Assert
            Assert.IsTrue(Str.IsPalindrome(input));
        }
        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void isPalidromeWithSpaceAndPunctuation()
        {
            // Arrange
            string input = "A man, a plan, a canal: Panama.";
            // Act

            // Assert
            Assert.IsTrue(Str.IsPalindrome(input));
        }        /// <summary>
                 /// test
                 /// </summary>
        [Test]
        public void EmptyStringisPalidrome()
        {
            // Arrange
            string input = "";
            // Act

            // Assert
            Assert.IsTrue(Str.IsPalindrome(input));
        }
    }
}