// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Carrots.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx1
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class carrots extending a class veggies
    /// </summary>
    /// <seealso cref="DesignPattern.ObserverDesignPatternEx1.Veggies" />
    public class Carrots : Veggies
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carrots"/> class.
        /// </summary>
        /// <param name="price">The price.</param>
        public Carrots(double price) : base(price)
        {
        }
    }
}
