using NUnit.Framework;
using MyMath;
using System;

/// <summary>
/// Exercice about Unit testing and TDD 
/// </summary>
/// <see cref="https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit"/>>

namespace MyMath.Tests
{

    /// <summary>
    ///  The [TestFixture] attribute denotes a class that contains unit tests.
    /// </summary> 
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
        ///  The [Test] attribute indicates a method is a test method.
        /// </summary> 
        [Test]
        public void Add_1_1_Equal_2()
        {
            // Arrange

            // Act
            int result = Operations.Add(1, 1);
            // Assert
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Add_2_3_Equal_5()
        {
            // Arrange

            // Act
            int result = Operations.Add(2, 3);
            // Assert
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Add_3_2_Equal_5()
        {
            // Arrange

            // Act
            int result = Operations.Add(3, 2);
            // Assert
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Add_3_n2_Equal_1()
        {
            // Arrange

            // Act
            int result = Operations.Add(3, -2);
            // Assert
            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Add_0_n2_Equal_n2()
        {
            // Arrange

            // Act
            int result = Operations.Add(0, -2);
            // Assert
            Assert.AreEqual(-2, result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Add_n5_n2_Equal_n7()
        {
            // Arrange

            // Act
            int result = Operations.Add(-5, -2);
            // Assert
            Assert.AreEqual(-7, result);
        }

        /*
        /// <summary>
        /// test exception
        /// </summary>
        /// <see cref="https://stackoverflow.com/questions/53255946/testing-exceptions-in-nunit-3-0-and-above"/>
        [TestCase(new[] { "a", 0 })]
        public void Add_Accept_Only_Int(<T|\\[] args)
        {
            // Arrange

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Operations.Add(args[0], args[1]));
            // encore mieux ?
            //addWithWrongTypeArg.Should().Throw<ArgumentException>().WithMessage("add integer only");
        }*/
    }
}