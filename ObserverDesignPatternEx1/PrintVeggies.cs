// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrintVeggies.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPatternEx1
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class to print the veggies
    /// </summary>
    public class PrintVeggies
    {
        /// <summary>
        /// Prints the details.
        /// </summary>
        public void PrintDetails()
        {
            Carrots carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Jack", 0.7));
            carrots.Attach(new Restaurant("Jill", 2.5));
            carrots.Attach(new Restaurant("Mickey", 1.75));
            //// Fluctuating carrot prices will notify subscribing restaurants.
            carrots.PricePerKg = 0.79;
            carrots.PricePerKg = 0.76;
            carrots.PricePerKg = 0.74;
            carrots.PricePerKg = 0.81;
            Console.ReadKey();
        }
    }
}
