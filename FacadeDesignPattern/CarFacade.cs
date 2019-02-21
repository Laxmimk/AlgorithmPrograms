// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CarFacade.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacadeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// class car facade
    /// </summary>
    public class CarFacade
    {
        /// <summary>
        /// The car model
        /// </summary>
        private CarModel model;

        /// <summary>
        /// The car engine
        /// </summary>
        private CarEngine engine;

        /// <summary>
        /// The car body
        /// </summary>
        private CarBody body;

        /// <summary>
        /// The car accessories
        /// </summary>
        private CarAccessories accessories;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarFacade"/> class.
        /// </summary>
        public CarFacade()
        {
            this.model = new CarModel();
            this.engine = new CarEngine();
            this.body = new CarBody();
            this.accessories = new CarAccessories();
        }

        /// <summary>
        /// Creates the complete car.
        /// </summary>
        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            this.model.SetModel();
            this.engine.SetEngine();
            this.body.SetBody();
            this.accessories.SetAccessories();
            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}
