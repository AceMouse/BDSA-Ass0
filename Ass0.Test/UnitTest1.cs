using System;
using Xunit;

namespace Ass0.Test
{
    public class LeapYearTest
    {
        [Fact]
        public void LeapYear_IsLeapYear(){

            var out2004 = LeapYear.IsLeapYear(2004);
            var out1996 = LeapYear.IsLeapYear(1996);
            var out1997 = LeapYear.IsLeapYear(1997);
            
            var out1700 = LeapYear.IsLeapYear(1700);
            var out1800 = LeapYear.IsLeapYear(1800);
            var out1900 = LeapYear.IsLeapYear(1900);
            var out2000 = LeapYear.IsLeapYear(2000);

            Assert.True(out2004);
            Assert.True(out1996);
            Assert.False(out1997);
            
            Assert.False(out1700);
            Assert.False(out1800);
            Assert.False(out1900);
            Assert.True(out2000);
            
        }
        
    }
}
