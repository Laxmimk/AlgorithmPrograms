// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Veggies.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx1
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class for veggies
    /// </summary>
    public class Veggies
    {
        /// <summary>
        /// The price per kg
        /// </summary>
        private double pricePerKg;

        /// <summary>
        /// The list of restaurants
        /// </summary>
        private List<IRestaurant> restaurants = new List<IRestaurant>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Veggies"/> class.
        /// </summary>
        /// <param name="pricePerkg">The price per k g.</param>
        public Veggies(double pricePerkg)
        {
            pricePerkg = this.pricePerKg;
        }

        /// <summary>
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double PricePerKg
        {
            get { return this.pricePerKg; }
            set
            {
                if (this.pricePerKg != value)
                {
                    this.pricePerKg = value;
                    this.Notify(); ////Automatically notify our observers of price changes
                }
            }
        }     

        /// <summary>
        /// Attaches the specified restaurant.
        /// </summary>
        /// <param name="restaurant">The restaurant.</param>
        public void Attach(IRestaurant restaurant)
        {
            //// Adds an restaurant to the list
            this.restaurants.Add(restaurant);
        }

        /// <summary>
        /// Detaches the specified restaurant.
        /// </summary>
        /// <param name="restaurant">The restaurant.</param>
        public void Detach(IRestaurant restaurant)
        {
            this.restaurants.Remove(restaurant);
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (IRestaurant restaurant in this.restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine("");
        }   
    }
}
