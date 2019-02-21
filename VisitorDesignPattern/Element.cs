// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Element.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An abstract class element
    /// </summary>
    public abstract class Element
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public abstract void Accept(IVisitor visitor);
    }
}
