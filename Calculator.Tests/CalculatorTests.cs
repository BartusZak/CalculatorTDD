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
    }
}
