﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calender.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class for calendar
    /// </summary>
    public class Calender
    {
        /// <summary>
        /// The week day
        /// </summary>
        private string week;

        /// <summary>
        /// The days falling on the day of the week
        /// </summary>
        private string[] days = new string[8];

        /// <summary>
        /// Sets the week day.
        /// </summary>
        /// <param name="weekday">The day of the week</param>
        public void SetWeekDay(string weekday)
        {
            this.week = weekday;
        }

        /// <summary>
        /// Returns the day of week.
        /// </summary>
        /// <returns>The day of the week held by this object</returns>
        public string ReturnDayofWeek()
        {
            return this.week;
        }

        /// <summary>
        /// Returns the days array.
        /// </summary>
        /// <returns>The array soring the number of days</returns>
        public string[] ReturnDays()
        {
            //// string days1 = this.days.ToString();
            //// foreach (string s in days) Console.Write(s.ToString());
            return this.days;
        }

        /// <summary>
        /// Stores the days in the array.
        /// </summary>
        /// <param name="day">The day to be added to the array</param>
        public void AddDays(int day)
        {
            int i = 0;
            //// while the space is empty to store new variabels
            while (this.days[i] != null)
            {
                i++;
            }

            this.days[i] = day.ToString() + "\t";
        }

        /// <summary>
        /// Adds the days in form of string.
        /// </summary>
        /// <param name="day">The day.</param>
        public void AddDays(string day)
        {
            this.days[0] = day;
        }

        /// <summary>
        /// Adds the space where the object if before 1st of the months.
        /// </summary>
        public void AddSpace()
        {
            int j = 0;

            //// while (this.days[i].Equals(null) != false) i++;

            for (j = 5; j >= 1; j--)
            {
                this.days[j] = this.days[j - 1];
            }

            this.days[0] = "\t";
        }
    }
}