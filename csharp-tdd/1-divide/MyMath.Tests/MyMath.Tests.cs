using NUnit.Framework;

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
        public void Divide_by_1()
        {
            // Arrange
            int[,] a = {
               { 1 , 2 , 3 , } ,
               { 4 , 5 , 6 , } ,
             };
            int b = 1;
            // Act
            int[,] result = Operations.Divide(a, b);
            // Assert
            Assert.AreEqual(a, result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Divide_by_n1()
        {
            // Arrange
            int[,] a = {
               { 1 , 2 , 3 , } ,
               { 4 , 5 , 6 , } ,
             };
            int b = -1;
            int[,] good = {
                { -1 , -2 , -3 , } ,
                { -4 , -5 , -6 ,} ,
             };
            // Act
            int[,] result = Operations.Divide(a, b);
            // Assert
            Assert.AreEqual(good, result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Divide_by_100()
        {
            // Arrange
            int[,] a = {
               { 1 , 2 , 3 , } ,
               { 4 , 5 , 6 , } ,
             };
            int b = 100;
            int[,] good = {
                { 0 , 0 , 0 , } ,
                { 0 , 0 , 0 ,} ,
             };
            // Act
            int[,] result = Operations.Divide(a, b);
            // Assert
            Assert.AreEqual(good, result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Divide_by_2()
        {
            // Arrange
            int[,] a = {
               { 2 , 4 , 6 , } ,
               { 8 , 10 , 12 , } ,
             };
            int b = 2;
            int[,] good = {
                { 1 , 2 , 3 , } ,
                { 4 , 5 , 6 ,} ,
             };
            // Act
            int[,] result = Operations.Divide(a, b);
            // Assert
            Assert.AreEqual(good, result);
        }
        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Divide_by_0_returns_null()
        {
            // Arrange
            int[,] a = {
               { 2 , 4 , 6 , } ,
               { 8 , 10 , 12 , } ,
             };
            int b = 0;
            // Act
            int[,] result = Operations.Divide(a, b);
            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// test
        /// </summary>
        [Test]
        public void Matrix_is_null_returns_null()
        {
            // Arrange
            int[,] a = null;
            int b = 2;
            // Act
            int[,] result = Operations.Divide(a, b);
            // Assert
            Assert.IsNull(result);
        }
    }
}