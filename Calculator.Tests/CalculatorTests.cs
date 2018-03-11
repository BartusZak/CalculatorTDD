using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        

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
