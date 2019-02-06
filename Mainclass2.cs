// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mainclass2.cs" company="Bridgelabz">
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
    /// A main class
    /// </summary>
    public class Mainclass
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Calendar c = new Calendar();
            string month = Convert.ToString(args[0]);
            int year = Convert.ToInt32(args[1]);
            c.Calendarprint(month, year);
        }
    }
}
