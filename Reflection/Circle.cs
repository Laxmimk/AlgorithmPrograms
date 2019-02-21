// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Circle.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Reflection
{
    using System;

    /// <summary>
    /// A class circle implementing an interface shape
    /// </summary>
    /// <seealso cref="DesignPattern.Reflection.IShape" />
    public class Circle : IShape
    {
        /// <summary>
        /// Draws this instance.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
