// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DecimaltoBinary.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// converting a decimal number to binary number
    /// </summary>
    public class DecimaltoBinary
    {
        /// <summary>
        /// A method for the conversion
        /// </summary>
        public void ConversionofDecimal()
        {
            //// creating an object of utility class
            Utility u = new Utility();
           string binarynumber = u.Conversionofdectobinary();
            Console.WriteLine("The binary representation of a given decimal number is : " + binarynumber);
            Console.ReadLine();
        }
    }
}
