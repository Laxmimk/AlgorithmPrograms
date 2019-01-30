// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DaysOfAWeek.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Mainclass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// class for finding a day of a week
    /// </summary>
    public class DaysOfAWeek
    {
        /// <summary>
        /// Finding the week day
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="m">The m.</param>
        /// <param name="y">The y.</param>
        public void FindingWeekOfADay(int d, int m, int y)
        {
            Utility utility = new Utility();
            utility.DaysOfAWeek(d, m, y);
        }
    }
}
