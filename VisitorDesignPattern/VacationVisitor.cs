// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VacationVisitor.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class vacation visitor implementing an interface visitor
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.IVisitor" />
    public class VacationVisitor : IVisitor
    {
        /// <summary>
        /// Visits the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Visit(Element element)
        {
            Employee employee = element as Employee;
            //// Provide extra 3 days vacation
            employee.VacationDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name, employee.VacationDays);
        }
    }
}
