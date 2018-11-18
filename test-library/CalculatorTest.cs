using System;
using Xunit;
using library;

namespace test_library
{
    public class CalculatorTest
    {
        [Fact]
        public void should_validate_sum()
        {
            var calculator = new Calculator();
            Assert.NotEqual(42, calculator.sum(20, 20));
            Assert.Equal(50, calculator.sum(20,30));
        }

        [Fact]
        public void should_validate_division(){
            var calculator = new Calculator();
            Assert.NotEqual(2, calculator.div(20, 20));
            Assert.Equal(1, calculator.div(20,20)); 
        }
    }
}
