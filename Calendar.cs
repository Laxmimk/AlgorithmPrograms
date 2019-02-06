// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calendar.cs" company="Bridgelabz">
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
    /// A class for printing a calendar
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Method prints the calendar of the month
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        public void Calendarprint(string month, int year)
        {
            try
            {
                CalendarUtility cu = new CalendarUtility();
                string[] months = new string[]
                {
               "jan", "feb", "march", "april", "may", "june", "july", "aug", "sept", "oct", "nov", "dec"
                };
                //// storing days
                string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
                //// starting date
                int day = 1;
                Console.WriteLine();
                //// taking month as input 
                // month = CalendarUtility.IsString(Console.ReadLine());
                month = month.ToLower();
                bool flag = false;
                int monthint = 0;
                //// checking if the string is a month
                foreach (string s in months)
                {
                    if (month.Equals(s))
                    {
                        flag = true;
                        break;
                    }

                    monthint++;
                }
               
                if (flag == false)
                {
                    Console.WriteLine("The string you mentioned is not a month");
                    return;
                }

                //// as days in feb may vary in leap year and other years 
                int febdays = 28, i = 0;
                if (cu.Leapyear(year) == true)
                {
                    febdays = 29;
                }
                //// storing number of months in each
                int[] numdaysinmonth = { 31, febdays, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string[,] calender = new string[7, 7];
                int counter = 0, j = 1;
                foreach (string s in days)
                {
                    calender[0, counter] = days[counter++] + "\t";
                }

                counter = 0;
                string daycalulated = cu.DaysOfAWeek(1, monthint + 1, year);
                i = 0;
                j = 0;
                while (daycalulated.Equals(days[i]) == false)
                {
                    calender[1, i] = "\t";
                    i++;
                }

                for (counter = 1; counter <= numdaysinmonth[monthint + 1]; counter++)
                {
                    daycalulated = cu.DaysOfAWeek(day, monthint + 1, year);
                    for (i = 0; i < 7; i++)
                    {
                        if (daycalulated.Equals(days[i]))
                        {
                            j = 1;
                            while (calender[j, i] != null)
                            {
                                j++;                               
                            }

                            calender[j, i] = day.ToString() + "\t";
                        }                      
                    }

                    day++;
                }

                Console.WriteLine(months[monthint] + " " + year);
                for (i = 0; i < 6; i++)
                {
                    for (j = 0; j < 7; j++)
                    {
                        Console.Write(calender[i, j]);
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
