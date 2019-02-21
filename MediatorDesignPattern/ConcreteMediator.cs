// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteMediator.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class concrete mediator extending a class mediator
    /// </summary>
    /// <seealso cref="DesignPattern.MediatorDesignPattern.Mediator" />
    public class ConcreteMediator : Mediator
    {
        /// <summary>
        /// The c colleague1
        /// </summary>
        private ConcreteColleague1 _colleague1;

        /// <summary>
        /// The c colleague2
        /// </summary>
        private ConcreteColleague2 _colleague2;

        /// <summary>
        /// Sets the colleague1.
        /// </summary>
        /// <value>
        /// The colleague1.
        /// </value>
        public ConcreteColleague1 Colleague1
        {
            set { this._colleague1 = value; }
        }

        /// <summary>
        /// Sets the colleague2.
        /// </summary>
        /// <value>
        /// The colleague2.
        /// </value>
        public ConcreteColleague2 Colleague2
        {
            set { this._colleague2 = value; }
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="colleague">The colleague.</param>
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == this._colleague1)
            {
                this._colleague2.Notify(message);
            }
            else
            {
                this._colleague1.Notify(message);
            }
        }
    }
}
