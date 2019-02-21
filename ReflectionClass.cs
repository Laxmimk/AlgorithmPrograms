// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReflectionClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Class reflection 
    /// </summary>
    public class ReflectionClass
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Reflection method to print the attributes of the class
        /// </summary>
        public void Reflection()
        {
            Type type = typeof(ReflectionClass);
            Console.WriteLine("The class's name, full name and namespace are : ==> ");
            //// Printing the name of the class
            Console.WriteLine("Class " + type.Name);
            //// Printing the full name of the class
            Console.WriteLine("Class " + type.FullName);
            //// Printing the name space of the the class
            Console.WriteLine("Class " + type.Namespace);
            Console.WriteLine();
            PropertyInfo[] pinfo = type.GetProperties();
            Console.WriteLine("The list of properties of the Customer class are : ==> ");
            foreach (PropertyInfo propertyInfo in pinfo)
            {
                //// Printing the names of the constructors in the class
                Console.WriteLine(propertyInfo.PropertyType.Name + " " + propertyInfo.Name);
            }          
        }
    }
}
