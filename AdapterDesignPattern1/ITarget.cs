// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITarget.cs" company="Bridgelabz">
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
    /// An interface Target
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Method to get the employee list
        /// </summary>
        /// <returns></returns>
        List<string> GetEmployeeList();
    }
}
