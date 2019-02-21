// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MathProxy.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ProxyDesignPattern
{
    using System;

    /// <summary>
    /// class math proxy implementing an interface math
    /// </summary>
    /// <seealso cref="DesignPattern.ProxyDesignPattern.IMath" />
    public class MathProxy : IMath
    {
        /// <summary>
        /// The math
        /// </summary>
        private Math math = new Math();

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
            return this.math.Add(x, y);
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
            return this.math.Sub(x, y);
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
            return this.math.Mul(x, y);
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
            return this.math.Div(x, y);
        }

        /// <summary>
        /// Prints the proxy.
        /// </summary>
        public void PrintProxy()
        {
            MathProxy proxy = new MathProxy();

            Console.WriteLine("The result of 4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("The result of 4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("The result of 4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("The result of 4 / 2 = " + proxy.Div(4, 2));
            Console.ReadKey();
        }
    }   
}
