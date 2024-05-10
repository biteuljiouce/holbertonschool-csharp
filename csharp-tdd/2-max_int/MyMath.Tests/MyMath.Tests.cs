using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{

    /// <summary>
    ///  The [TestFixture] attribute denotes a class that contains unit tests.
    /// </summary> 
    /// <see cref="https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit"/>>
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>
        /// does nothing.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Max()
        {
            // Arrange
            List<int> list = new List<int> { 1, 2, 3 };
            int good = 3;
            // Act
            int result = Operations.Max(list);
            // Assert
            Assert.AreEqual(good, result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Max2()
        {
            // Arrange
            List<int> list = new List<int> { 1, 15, -20 };
            int good = 15;
            // Act
            int result = Operations.Max(list);
            // Assert
            Assert.AreEqual(good, result);
        }
        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void list_is_empty_returns_0()
        {
            // Arrange
            List<int> list = new List<int> { };
            int good = 0;
            // Act
            int result = Operations.Max(list);
            // Assert
            Assert.AreEqual(good, result);
        }

    }
}