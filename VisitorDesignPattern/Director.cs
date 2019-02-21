// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Director.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class director extending a class employee
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.Employee" />
    public class Director : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Director"/> class.
        /// </summary>
        public Director() : base("Jack", 35000, 16)
        {
        }
    }
}
