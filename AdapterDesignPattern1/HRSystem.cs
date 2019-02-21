// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HRSystem.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.AdapterDesignPattern1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class HR system
    /// </summary>
    public class HRSystem
    {
        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns>Return employees</returns>
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];
            employees[0] = new string[] { "100", "Deepak", "Team Leader" };
            employees[1] = new string[] { "101", "Rohit", "Developer" };
            employees[2] = new string[] { "102", "Gautam", "Developer" };
            employees[3] = new string[] { "103", "Dev", "Tester" };
            return employees;
        }
    }
}
