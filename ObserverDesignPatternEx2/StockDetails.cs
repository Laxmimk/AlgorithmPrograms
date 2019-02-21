// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockDetails.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx2
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class for stock details
    /// </summary>
    public class StockDetails
    {
        /// <summary>
        /// Prints the stock details.
        /// </summary>
        public void PrintStockDetails()
        {
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Ambani"));
            ibm.Attach(new Investor("Birla"));
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            Console.ReadKey();
        }
    }
}
