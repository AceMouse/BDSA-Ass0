using System;

namespace Ass0{

    public static class LeapYear{

        public static bool IsLeapYear(int year){
            return (year & 0b11) == 0 && (year%100 != 0 || year%400 == 0);
        }

    }

}