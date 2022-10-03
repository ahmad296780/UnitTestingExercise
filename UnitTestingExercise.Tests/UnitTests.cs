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
            Calculator obj = new Calculator();
           var actual =  obj.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 2, 5)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            Calculator obj1 = new Calculator();
           var actual =  obj1.Subtract(minuend, subtrhend);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            Calculator obj = new Calculator();
            var actual = obj.Multiply(num1, num2);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,1)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            Calculator obj = new Calculator();
            var actual = obj.divide(num1 , num2);
            Assert.Equal(expected, actual);
        }

    }
}
