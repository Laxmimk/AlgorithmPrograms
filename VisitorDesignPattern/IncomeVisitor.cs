// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IncomeVisitor.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class income visitor implementing visitor interface
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.IVisitor" />
    public class IncomeVisitor : IVisitor
    {
        /// <summary>
        /// Visits the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Visit(Element element)
        {
            Employee employee = element as Employee;
            //// Provide 10% pay raise
            employee.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income is : {2}", employee.GetType().Name, employee.Name, employee.Income);
        }
    }
}
