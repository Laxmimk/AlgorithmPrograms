// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VendorAdapter.cs" company="Bridgelabz">
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
    /// Class vendor adapter implementing an interface target 1 and extending a class 
    /// </summary>
    /// <seealso cref="DesignPattern.AdapterDesignPattern2.VendorAdaptee" />
    /// <seealso cref="DesignPattern.AdapterDesignPattern2.ITarget1" />
    public class VendorAdapter : VendorAdaptee, ITarget1
    {
        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns>
        /// Returns the list of products
        /// </returns>
        public List<string> GetProducts()
        {
            VendorAdaptee adaptee = new VendorAdaptee();
            return adaptee.GetListOfProducts();
        }

        /// <summary>
        /// Prints the items.
        /// </summary>
        public void PrintItems()
        {
            ITarget1 adapter = new VendorAdapter();
            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }
    }  
}
