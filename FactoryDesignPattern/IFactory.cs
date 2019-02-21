// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFactory.cs" company="Bridgelabz">
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
    /// An interface of factory
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        void Drive(int miles);
    }
}
