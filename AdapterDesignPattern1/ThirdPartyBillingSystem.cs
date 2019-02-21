// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThirdPartyBillingSystem.cs" company="Bridgelabz">
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
    /// A class for third party billing system
    /// </summary>
    public class ThirdPartyBillingSystem
    {
        /// <summary>
        /// The employee source
        /// </summary>
        private ITarget employeeSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyBillingSystem"/> class.
        /// </summary>
        /// <param name="employeeSource">The employee source.</param>
        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        /// <summary>
        /// Shows the employee list.
        /// </summary>
        public void ShowEmployeeList()
        {
            //// Storing the employees in yhe list
            List<string> employee = this.employeeSource.GetEmployeeList();
            Console.WriteLine("********** Employee List ***********");
            foreach (var item in employee)
            {
                Console.WriteLine(item);
            }
        }
    }
}
