using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 2, 2.0f)]
        [InlineData(-4, 2, -2.0f)]
        [InlineData(4, -2, -2.0f)]
        [InlineData(0, 3, 0.0f)]
        [InlineData(5, 2, 2.5f)]
        [InlineData(1, 3, 0.333333343f)]
        public void Divide_ReturnsProperValue(int dividend, int divisor, float expectedQuotient)
        {
            var calc = new Calculator();
            var quotient = calc.Divide(dividend, divisor);
            Assert.Equal(expectedQuotient, quotient);
        }

        [Fact]
        public void Divide_DivisionByZero_ThrowsException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
        }

        [Fact]
        public void Divide_OnCalculatedEventIsCalled()
        {
            var calc = new Calculator();

            bool wasEventCalled = false;
            calc.CalculatedEvent += (sender, args) => wasEventCalled = true;

            calc.Divide(1, 2);

            Assert.True(wasEventCalled);
        }

        [Fact]
        public void Add_AddsTwoPositiveNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(2, 2);
            Assert.Equal(4, sum);
        }

        [Fact]
        public void Add_AddsTwoNegativeNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add((-2), (-2));
            Assert.Equal((-4), sum);
        }

        [Fact]
        public void Add_AddsPositiveToNegativeNumber_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(2, (-2));
            Assert.Equal(0, sum);
        }

        [Fact]
        public void Add_AddsNegativeToPositiveNumber_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add((-2), 2);
            Assert.Equal(0, sum);
        }
    }
}
