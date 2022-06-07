using System;

namespace LeapYear
{
    public class LeapYear
    {
        private readonly int Year;
        public LeapYear(int year)
        {
            Year = year;
        }
        public bool IsLeapYear()
        {
            bool isDivisibleBy4 = IsDivisibleBy(4);
            bool isDivisibleBy400 = IsDivisibleBy(400);
            bool isDivisibleBy100 = IsDivisibleBy(100);

            return (isDivisibleBy4 || isDivisibleBy400) && !(isDivisibleBy100 && !isDivisibleBy400);
        }

        private bool IsDivisibleBy(int value)
        {
            return Year % value == 0;
        }
    }
}
