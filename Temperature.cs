// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Temperature.cs" company="Bridgelabz">
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
    /// converting the temperature in celsius to Fahrenheit and vice versa
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// a method for temperature conversion
        /// </summary>
        public void TemperatureConversion()
        {
            try
            {
                double c, f;
                //// the celcius to convert into fahrenheit
                Console.WriteLine("Enter the temperature in celcius");
                c = Utility.Getdouble();
                f = (c * 9 / 5) + 32;
                Console.WriteLine(c + "°C in Fahrenheit is: " + f + "°F");
                //// the fahrenheit to convert into celcius
                Console.WriteLine("Enter the temperature in fahrenheit");
                f = Utility.Getdouble();
                c = (f - 32) * 5 / 9;
                Console.WriteLine(f + "°F in Celcius is: " + c + "°C");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
