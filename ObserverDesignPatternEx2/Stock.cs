// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stock.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx2
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An abstract class stock
    /// </summary>
    public abstract class Stock
    {
        /// <summary>
        /// The symbol
        /// </summary>
        private string _symbol;

        /// <summary>
        /// The price
        /// </summary>
        private double _price;

        /// <summary>
        /// The investors list
        /// </summary>
        private List<IInvestor> _investors = new List<IInvestor>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="price">The price.</param>
        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price
        {
            get
            {
                return this._price;
            }

            set
            {
                if (this._price != value)
                {
                    this._price = value;
                    this.Notify();
                }
            }
        }

        /// <summary>
        /// Gets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol
        {
            get
            {
                return this._symbol;
            }
        }

        /// <summary>
        /// Attaches the specified investor.
        /// </summary>
        /// <param name="investor">The investor.</param>
        public void Attach(IInvestor investor)
        {
            this._investors.Add(investor);
        }

        /// <summary>
        /// Detaches the specified investor.
        /// </summary>
        /// <param name="investor">The investor.</param>
        public void Detach(IInvestor investor)
        {
            this._investors.Remove(investor);
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (IInvestor investor in this._investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }
    }
}