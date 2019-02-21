// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Math.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ProxyDesignPattern
{
    using System;

    /// <summary>
    /// Class math implementing an interface math
    /// </summary>
    /// <seealso cref="DesignPattern.ProxyDesignPattern.IMath" />
    public class Math : IMath
    {
        /// <summary>
        /// Adds the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>
        /// Returns addition of two variables
        /// </returns>
        public double Add(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Subtract the values of x and y
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>
        /// Returns subtraction of variables
        /// </returns>
        public double Sub(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// Multiplies the values of x and y
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>
        /// Returns multiplication
        /// </returns>
        public double Mul(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Divide the values of x and y
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>
        /// Returns division
        /// </returns>
        public double Div(double x, double y)
        {
            return x / y;
        }
    }
}
