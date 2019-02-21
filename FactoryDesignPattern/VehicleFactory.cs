// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleFactory.cs" company="Bridgelabz">
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
    /// An abstract class for vehicle factory
    /// </summary>
    public abstract class VehicleFactory
    {
        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns>Returns the vehicle</returns>
        public abstract IFactory GetVehicle(string vehicle);    
    }
}
