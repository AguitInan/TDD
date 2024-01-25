using Exercice02.Core;
using NUnit.Framework;
using System.Collections.Generic;
using Exercice02;

namespace Exercice02.NUnit
{
    [TestFixture]
    public class FibTests
    {
        [Test]
        public void GetFibSeries_WhenRangeIs1_ShouldReturnListWithOnlyZero()
        {
            // Arrange
            var fib = new Fib(1);

            // Act
            var result = fib.GetFibSeries();

            // Assert
            Assert.That(result, Has.Exactly(1).EqualTo(0));
        }

        [Test]
        public void GetFibSeries_WhenRangeIs6_ShouldContainNumberThree()
        {
            // Arrange
            var fib = new Fib(6);

            // Act
            var result = fib.GetFibSeries();

            // Assert
            Assert.That(result, Does.Contain(3));
        }

        [Test]
        public void GetFibSeries_WhenRangeIs6_ShouldHaveSixElements()
        {
            // Arrange
            var fib = new Fib(6);

            // Act
            var result = fib.GetFibSeries();

            // Assert
            Assert.That(result, Has.Exactly(6).Items);
        }

        [Test]
        public void GetFibSeries_WhenRangeIs6_ShouldNotContainNumberFour()
        {
            // Arrange
            var fib = new Fib(6);

            // Act
            var result = fib.GetFibSeries();

            // Assert
            Assert.That(result, Does.Not.Contain(4));
        }

        [Test]
        public void GetFibSeries_WhenRangeIs6_ShouldReturnExpectedList()
        {
            // Arrange
            var fib = new Fib(6);
            var expected = new List<int> { 0, 1, 1, 2, 3, 5 };

            // Act
            var result = fib.GetFibSeries();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetFibSeries_WhenRangeIs6_ShouldBeSortedAscending()
        {
            // Arrange
            var fib = new Fib(6);

            // Act
            var result = fib.GetFibSeries();

            // Assert
            Assert.That(result, Is.Ordered.Ascending);
        }
    }
}
