// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyModel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------using System;

namespace OopsPrograms
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class model for company
    /// </summary>
    public class CompanyModel
    {
        /// <summary>
        /// The company name
        /// </summary>
        private string companyName;

        /// <summary>
        /// The symbol
        /// </summary>
        private string symbol;

        /// <summary>
        /// The share
        /// </summary>
        private int share;

        /// <summary>
        /// The price
        /// </summary>
        private int price;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.companyName; set => this.companyName = value; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get => this.symbol; set => this.symbol = value; }

        /// <summary>
        /// Gets or sets the share.
        /// </summary>
        /// <value>
        /// The share.
        /// </value>
        public int Share { get => this.share; set => this.share = value; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public int Price { get => this.price; set => this.price = value; }
    }
}
