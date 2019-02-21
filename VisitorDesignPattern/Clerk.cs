// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Clerk.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class clerk extending a class employee
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.Employee" />
    public class Clerk : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clerk"/> class.
        /// </summary>
        public Clerk() : base("Jill", 25000, 14)
        {
        }
    }
}
