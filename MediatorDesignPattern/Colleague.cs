// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Colleague.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class colleague
    /// </summary>
    public class Colleague
    {
        /// <summary>
        /// The mediator
        /// </summary>
        protected Mediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="Colleague"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
