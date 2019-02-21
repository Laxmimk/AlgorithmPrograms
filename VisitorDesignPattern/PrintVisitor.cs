// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrintVisitor.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class print visitor
    /// </summary>
    public class PrintVisitor
    {
        /// <summary>
        /// Prints the details of visitor.
        /// </summary>
        public void PrintDetailsOfVisitor()
        {
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
            Console.ReadKey();
        }
    }
}
