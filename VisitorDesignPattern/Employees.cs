// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employees.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class Employees
    /// </summary>
    public class Employees
    {
        /// <summary>
        /// The employee list
        /// </summary>
        private List<Employee> emp = new List<Employee>();

        /// <summary>
        /// Attaches the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void Attach(Employee employee)
        {
            this.emp.Add(employee);
        }

        /// <summary>
        /// Detaches the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void Detach(Employee employee)
        {
            this.emp.Remove(employee);
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in this.emp)
            {
                e.Accept(visitor);
            }

            Console.WriteLine();
        }
    }
}
