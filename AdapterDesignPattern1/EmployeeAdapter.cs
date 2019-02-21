// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeAdapter.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.AdapterDesignPattern1
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Employee adapter extending a class and implementing the interface Target respectively
    /// </summary>
    /// <seealso cref="DesignPattern.AdapterDesignPattern1.HRSystem" />
    /// <seealso cref="DesignPattern.AdapterDesignPattern1.ITarget" />
    public class EmployeeAdapter : HRSystem, ITarget
    {
        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns>Employee list</returns>
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            try
            {
                string[][] employees = GetEmployees();
                foreach (string[] employee in employees)
                {
                    employeeList.Add(employee[0]);
                    employeeList.Add(employee[1]);
                    employeeList.Add(employee[2]);
                    employeeList.Add("\n");
                }
            }
             catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return employeeList;
        }
    }
}
