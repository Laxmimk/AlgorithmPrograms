// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShapeFactory.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Reflection
{
    using System;
    using System.Reflection;

    /// <summary>
    /// A class for shape factory
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// Gets the shape.
        /// </summary>
        /// <typeparam name="T">interface shape</typeparam>
        /// <returns>Returns an instance</returns>
        public static IShape GetShape<T>() where T : IShape
        {
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        /// Gets the shape.
        /// </summary>
        /// <param name="shapeName">Name of the shape.</param>
        /// <returns>Returns an instance</returns>
        public static IShape GetShape(string shapeName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetType(shapeName).FullName;
            return (IShape)Activator.CreateInstanceFrom(assembly.Location, type).Unwrap();
        }
    }
}