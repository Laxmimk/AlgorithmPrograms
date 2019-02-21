// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructorInjection.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection
{
    using System;

    /// <summary>
    /// class Constructor injection
    /// </summary>
    public class ConstructorInjection
    {
        /// <summary>
        /// The text
        /// </summary>
        private IText text;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructorInjection"/> class.
        /// </summary>
        /// <param name="t1">The t1.</param>
        public ConstructorInjection(IText t1)
        {
            this.text = t1;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            text.Print();
        }
    }
}
