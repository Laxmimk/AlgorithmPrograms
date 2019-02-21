// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrintConstructor.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection
{
    using System;

    /// <summary>
    /// The class print constructor
    /// </summary>
    public class PrintConstructor
    {
        /// <summary>
        /// A constructor of the class 
        /// </summary>
        public void ConstructorPrint()
        {
            //// An object of constructor injection
            ConstructorInjection cs = new ConstructorInjection(new Format());
            cs.Print();
            Console.ReadKey();
        }
    }
}
