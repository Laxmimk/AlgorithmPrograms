// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVisitor.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An interface visitor
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Visits the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        void Visit(Element element);
    }
}
