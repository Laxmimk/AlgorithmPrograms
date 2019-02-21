// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Reflection
{
    using System;

    /// <summary>
    /// A class rectangle implementing an interface shape
    /// </summary>
    /// <seealso cref="DesignPattern.Reflection.IShape" />
    public class Rectangle : IShape
    {
        /// <summary>
        /// Draws this instance.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
