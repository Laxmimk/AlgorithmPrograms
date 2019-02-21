// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteColleague1.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// a class concrete colleague extending a class colleague
    /// </summary>
    /// <seealso cref="DesignPattern.MediatorDesignPattern.Colleague" />
    public class ConcreteColleague1 : Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteColleague1"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        /// <summary>
        /// Notifies the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: " + message);
        }
    }
}
