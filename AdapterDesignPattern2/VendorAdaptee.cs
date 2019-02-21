// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VendorAdaptee.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.AdapterDesignPattern2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The class for vendor
    /// </summary>
    public class VendorAdaptee
    {
        /// <summary>
        /// Gets the list of products.
        /// </summary>
        /// <returns>Returns the products</returns>
        public List<string> GetListOfProducts()
        {
            //// Creating a list of products
            List<string> products = new List<string>();
            //// Adding the values to the list
            products.Add("Gaming Consoles");
            products.Add("Television");
            products.Add("Books");
            products.Add("Musical Instruments");
            return products;
        }
    }
}
