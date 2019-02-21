// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrintReflection.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Reflection
{
    using System;

    /// <summary>
    /// A class for printing a reflection
    /// </summary>
    public class PrintReflection
    {
        /// <summary>
        /// Reflections the details.
        /// </summary>
        public void ReflectionDetails()
        {
            Console.WriteLine("Drawing the shapes : ");
            var shape = ShapeFactory.GetShape<Circle>();
            var shape2 = ShapeFactory.GetShape<Rectangle>();
            shape.Draw();
            shape2.Draw();
            Console.ReadKey();
        }
    }
}
