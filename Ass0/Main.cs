using System;

namespace Ass0 
{

    class MainClass 
    {

        static void Main(string[] args) 
        {
            Console.Write("Type in a year to check for leapiness, then hit [Enter]\n\t>>>");
            if (LeapYear.IsLeapYear(Int32.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Yay!");
            } else
            {
                Console.WriteLine("Nay!");
            }
        }

    }

}