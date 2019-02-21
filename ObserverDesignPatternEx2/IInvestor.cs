// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInvestor.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx2
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An interface for investor
    /// </summary>
    public interface IInvestor
    {
        /// <summary>
        /// Updates the specified stock.
        /// </summary>
        /// <param name="stock">The stock.</param>
        void Update(Stock stock);
    }
}
