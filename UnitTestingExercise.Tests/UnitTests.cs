using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests 
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calcultor = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = calcultor.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Subtract(minuend, subtrhend);

            //Assert

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(2, 2, 4)]//Add test data <-------
        [InlineData(4, 4, 16)]//Add test data <-------
        [InlineData(3, 3, 9)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act

            var result = calculator.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(10,5,2)]//Add test data <-------
        [InlineData(25, 5, 5)]//Add test data <-------
        [InlineData(3, 3, 1)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var calculator = new Calculator();

            //Act
            var result = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}
