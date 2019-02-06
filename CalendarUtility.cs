// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalendarUtility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A utility class
    /// </summary>
    public class CalendarUtility
    {
        /// <summary>
        /// Determines whether the specified input is integer.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns>It returns a integer value</returns>
        public static int IsInteger(string input, int min, int max)
        {
            int num;
            if (int.TryParse(input, out num) && (num >= min && num <= max))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                bool flag = false;
                while (flag == false)
                {
                    if (int.TryParse(input, out num) == false)
                    {
                        Console.WriteLine("Enter the valid input");
                        input = Console.ReadLine();
                    }

                    if (num < min || num > max)
                    {
                        Console.WriteLine("It is not a valid input");
                        input = Console.ReadLine();
                    }

                    flag = true;
                }
            }

            return Convert.ToInt32(input);
        }

        /// <summary>
        /// Determines whether the specified input is string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>It returns a string</returns>
        public static string IsString(string input)
        {
            int flag = 1;
            do
            {
                int i = 0;
                if (input.Contains("  "))
                {
                    flag = 1;
                    Console.WriteLine("You have entered moe than 1 space, please try again");
                    input = Console.ReadLine();
                }
                //// it checks it the string has spaces
                for (i = 0; i < 10; i++)
                {
                    if (input.Contains(i.ToString()))
                    {
                        flag = 1;
                        Console.WriteLine("You have entered number in string it should not be please try again");
                        input = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
            }
            while (flag == 1);
            return input;
        }

        /// <summary>
        /// Checks day of the week on the date provided
        /// </summary>
        /// <param name="d">The date on the day</param>
        /// <param name="m">Month in the date</param>
        /// /// <param name="y">Year in the date</param>
        /// <returns>the day of the week</returns>
        public string DaysOfAWeek(int d, int m, int y)
        {
            int y0, x, m0, d0;
            y0 = y - ((14 - m) / 12);
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            m0 = m + (12 * ((14 - m) / 12)) - 2;
            d0 = (d + x + (31 * m0 / 12)) % 7;
            string[] months = new string[]
            {
                "January", "Feb", "March", "April", "May", "June", "July", "August", "September", "October", "November",
                        "December"
            };
            string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
            return days[d0];
        }

        /// <summary>
        /// A class leap year finds whether the given year is leap year or not
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>It returns true for leap year and false if it is not a leap year</returns>
        public bool Leapyear(int year)
        {
            if ((year % 100) == 0)
            {
                if ((year % 400) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if ((year % 4) == 0)
            {
                return true;
            }

            return false;
        }       
    }
}
