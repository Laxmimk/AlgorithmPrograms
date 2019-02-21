// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRestaurant.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx1
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An interface restaurant
    /// </summary>
    public interface IRestaurant
    {
        /// <summary>
        /// Updates the specified veggies.
        /// </summary>
        /// <param name="veggies">The veggies.</param>
        void Update(Veggies veggies);
    }
}
