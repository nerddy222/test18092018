using System;
using Xunit;
using FluentAssertions;
using FluentAssertions.Collections;
using myapi.Controllers;

namespace myapi.Test

{
    public class UnitTest1
    {
        [Theory(DisplayName = "ฟังก์ชันบวกเลข")]
        [InlineData(1, 1, 2)]
        [InlineData(5, 5, 10)]
        [InlineData(2, 1, 3)]
        [InlineData(99, 108, 207)]
        [InlineData(-59, 130, 71)]
        public void TestPlus(int num1, int num2, int expectedValue)
        {
            var call = new CalculaterController();
            var sum = call.Plus(num1, num2);
            sum.Should().Be(expectedValue);
        }
        // 1000,500,100,50,20,10,5,2,1
        [Theory(DisplayName = "ทอนเงินแสดงจำนวนแบงค์")]
        [InlineData(1000, new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 })]
        [InlineData(2500, new int[] { 2, 1, 0, 0, 0, 0, 0, 0, 0 })]
        [InlineData(58400, new int[] { 58, 0, 4, 0, 0, 0, 0, 0 ,0})]
        [InlineData(152, new int[] { 0, 0, 1, 1, 0, 0, 0, 1, 0 })]
        public void TestWithdrawCash(int change, int[] expectedResult)
        {
            var call = new CalculaterController();
            var result = call.WithdrawCash(change);
            Assert.Equal(expectedResult, result);
        }
    }
}
