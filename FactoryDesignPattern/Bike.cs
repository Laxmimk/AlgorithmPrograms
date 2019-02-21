// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bike.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FactoryDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class bike implementing an interface factory
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.IFactory" />
    public class Bike : IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the bike : " + miles.ToString() + "km");
        }
    }
}
