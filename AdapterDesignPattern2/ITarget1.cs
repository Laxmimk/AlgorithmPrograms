// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITarget1.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.AdapterDesignPattern2
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An interface for target 1
    /// </summary>
    public interface ITarget1
    {
        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns>Returns the list of products</returns>
        List<string> GetProducts();
    }
}
