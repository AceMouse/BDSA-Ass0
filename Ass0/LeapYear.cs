using System;

namespace Ass0{

    public static class LeapYear{

        public static bool IsLeapYear(int year){
            if (year < 1582) 
                throw new ArgumentOutOfRangeException("Year is before 1582!");
            return (year & 0b11) == 0 && (year%100 != 0 || year%400 == 0);
        }

    }

}