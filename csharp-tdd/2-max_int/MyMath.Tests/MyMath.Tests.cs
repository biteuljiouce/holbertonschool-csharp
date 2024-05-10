using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

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
        /// <remarks>
        /// Puisque on ne peut avoir que des types contant dans les TestCase,
        /// on ne peut pas avoir de list d'entier, par exemple.
        /// Du coup, petite astuce : on y met une string qu'on transforme ensuite en list  
        /// </remarks>
        [TestCase("1, 2, 3", 3)]
        [TestCase("1, 15, -20", 15)]
        [TestCase("15, 15, 15", 15)]
        [TestCase("-15, -5, -150", -5)]
        [TestCase("0, 0, 0, 0", 0)]
        [TestCase("1, 0, 0, 0", 1)]
        public void ManyMaxTests(string listAsString, int good)
        {
            // Arrange
            var list = listAsString.Split(',')
                         .Select(int.Parse)
                         .ToList();
            // Act
            int result = Operations.Max(list);
            // Assert
            Assert.AreEqual(good, result);
        }

        /// <summary>
        /// test empty list.
        /// </summary>
        [Test]
        public void Empty_list_returns_0()
        {
            // Arrange
            List<int> list = new List<int>();
            int good = 0;
            // Act
            int result = Operations.Max(list);
            // Assert
            Assert.AreEqual(good, result);
        }
    }
}