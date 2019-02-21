// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteVehicleFactory.cs" company="Bridgelabz">
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
    /// A class concrete vehicle factory extending a class vehicle factory
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.VehicleFactory" />
    public class ConcreteVehicleFactory : VehicleFactory
    {
        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns>Returns vehicle</returns>
        /// <exception cref="ApplicationException">Application exception</exception>
        public override IFactory GetVehicle(string vehicle)
        {
           switch (vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", vehicle));
            }
        }

        /// <summary>
        /// Prints the method.
        /// </summary>
        public void PrintMethod()
        {
            VehicleFactory factory = new ConcreteVehicleFactory();
            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(20);
            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(25);
            Console.ReadKey();
        }
    }
}
