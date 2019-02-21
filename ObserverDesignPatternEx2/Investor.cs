// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Investor.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx2
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class investor implementing an interface investor
    /// </summary>
    /// <seealso cref="DesignPattern.ObserverDesignPatternEx2.IInvestor" />
    public class Investor : IInvestor
    {
        /// <summary>
        /// The name
        /// </summary>
        private string _name;

        /// <summary>
        /// The stock
        /// </summary>
        private Stock _stock;

        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public Stock Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Investor"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Investor(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// Updates the specified stock.
        /// </summary>
        /// <param name="stock">The stock.</param>
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "stock change to {2}", this._name, stock.Symbol, stock.Price);
        }
    }
}
