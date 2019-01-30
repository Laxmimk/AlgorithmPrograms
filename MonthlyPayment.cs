// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
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
    /// to calculate the monthly payment
    /// </summary>
    public class MonthlyPayment
    {
        /// <summary>
        /// a method for calculating a monthly payment
        /// </summary>
        /// <param name="years">The years.</param>
        /// <param name="rate">The rate.</param>
        /// <param name="principle">The principle.</param>
        public void CalculationofMonthlypayment(double years, double rate, int principle)
        {
            Utility utility = new Utility();
            utility.Monthlypayment(years, rate, principle);
        }
    }
}
