using System;
using Xunit;

namespace LeapYear.UnitTests
{

    public class LeapYearShould
    {
        [Theory]
        [InlineData(1996)]
        [InlineData(1600)]
        public void BeALeapYear(int year)
        {
            Assert.True(Year(year).IsLeapYear());
        }

        [Theory]
        [InlineData(1997)]
        [InlineData(1800)]
        public void NotBeALeapYear(int year)
        {
            Assert.False(Year(year).IsLeapYear());
        }

        private LeapYear Year(int year)
        {
            return new LeapYear(year);
        }
    }
}
