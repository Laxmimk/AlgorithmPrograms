// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Restaurant.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx1
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// a class restaurant implementing an interface restaurant
    /// </summary>
    /// <seealso cref="DesignPattern.ObserverDesignPatternEx1.IRestaurant" />
    public class Restaurant : IRestaurant
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The purchase threshold
        /// </summary>
        private double dPurchaseThreshold;

        /// <summary>
        /// Initializes a new instance of the <see cref="Restaurant"/> class.
        /// </summary>
        /// <param name="restaurantName">Name of the restaurant.</param>
        /// <param name="purchaseThreshold">The purchase threshold.</param>
        public Restaurant(string restaurantName, double purchaseThreshold)
        {
            this.name = restaurantName;
            this.dPurchaseThreshold = purchaseThreshold;
        }

        /// <summary>
        /// Updates the specified veggie.
        /// </summary>
        /// <param name="veggie">The veggie.</param>
        public void Update(Veggies veggie)
        {
            Console.WriteLine("{0} of {1}'s " + " price change to {2} per kg.", this.name, veggie.GetType().Name, veggie.PricePerKg);
            if (veggie.PricePerKg < this.dPurchaseThreshold)
            {
                Console.WriteLine(this.name + " wants to buy some " + veggie.GetType().Name + "!");
            }
        }
    }
}
