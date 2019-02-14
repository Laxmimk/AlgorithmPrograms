// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryModel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OopsPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// class model for inventory 
    /// </summary>
    public class InventoryModel
    {
        /// <summary>
        /// The item
        /// </summary>
        private string item;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The weight of item
        /// </summary>
        private int weightOfItem;

        /// <summary>
        /// The price of item
        /// </summary>
        private int priceOfItem;

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>
        /// The item.
        /// </value>
        public string Item { get => this.item; set => this.item = value; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the weight of item.
        /// </summary>
        /// <value>
        /// The weight of item.
        /// </value>
        public int WeightOfItem { get => this.weightOfItem; set => this.weightOfItem = value; }

        /// <summary>
        /// Gets or sets the price of item.
        /// </summary>
        /// <value>
        /// The price of item.
        /// </value>
        public int PriceOfItem { get => this.priceOfItem; set => this.priceOfItem = value; }
    }
}
