// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Format.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection
{
    using System;

    /// <summary>
    /// The class format extending a class text
    /// </summary>
    /// <seealso cref="DesignPattern.DependencyInjection.Text" />
    public class Format : IText
    {
        /// <summary>
        /// Prints the instance.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("This is the text format");
        }
    }
}
