// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomerModel.cs" company="Bridgelabz">
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
    /// class customer model
    /// </summary>
    public class CustomerModel
    {
        /// <summary>
        /// The id of the customer
        /// </summary>
        private int id;

        /// <summary>
        /// The name of the customer
        /// </summary>
        private string name;

        /// <summary>
        /// The number of shares customer has
        /// </summary>
        private int share;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get => this.id; set => this.id = value; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the share.
        /// </summary>
        /// <value>
        /// The share.
        /// </value>
        public int Share { get => this.share; set => this.share = value; }
    }
}
