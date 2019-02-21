// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMath.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ProxyDesignPattern
{
    using System;

    /// <summary>
    /// An interface of math 
    /// </summary>
    public interface IMath
    {
        /// <summary>
        /// Adds the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Returns addition of two variables</returns>
        double Add(double x, double y);

        /// <summary>
        /// Subtract the values of x and y
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Returns subtraction of variables</returns>
        double Sub(double x, double y);

        /// <summary>
        /// Multiplies the values of x and y
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Returns multiplication</returns>
        double Mul(double x, double y);

        /// <summary>
        /// Divide the values of x and y
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Returns division</returns>
        double Div(double x, double y);
    }
}
