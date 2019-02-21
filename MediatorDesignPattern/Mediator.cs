// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mediator.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An abstract class mediator
    /// </summary>
    public abstract class Mediator
    {
        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="colleague">The colleague.</param>
        public abstract void Send(string message, Colleague colleague);
    }
}
