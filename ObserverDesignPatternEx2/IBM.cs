// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBM.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx2
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class i b m extending a class stock
    /// </summary>
    /// <seealso cref="DesignPattern.ObserverDesignPatternEx2.Stock" />
    public class IBM : Stock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IBM"/> class.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="price">The price.</param>
        public IBM(string symbol, double price) : base(symbol, price)
        { 
        }
    }
}
