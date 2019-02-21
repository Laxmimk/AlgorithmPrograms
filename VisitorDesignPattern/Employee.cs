// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class employee extending a class element
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.Element" />
    public class Employee : Element
    {
        /// <summary>
        /// The name
        /// </summary>
        private string _name;

        /// <summary>
        /// The income
        /// </summary>
        private double _income;

        /// <summary>
        /// The vacation days
        /// </summary>
        private int _vacationDays;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="income">The income.</param>
        /// <param name="vacationDays">The vacation days.</param>
        public Employee(string name, double income, int vacationDays)
        {
            this._name = name;
            this._income = income;
            this._vacationDays = vacationDays;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// Gets or sets the income.
        /// </summary>
        /// <value>
        /// The income.
        /// </value>
        public double Income
        {
            get { return this._income; }
            set { this._income = value; }
        }

        /// <summary>
        /// Gets or sets the vacation days.
        /// </summary>
        /// <value>
        /// The vacation days.
        /// </value>
        public int VacationDays
        {
            get { return this._vacationDays; }
            set { this._vacationDays = value; }
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
