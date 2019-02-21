// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingletonEx.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Singleton
{
    using System;

    /// <summary>
    /// Singleton example class for not creating an instance of the class more then once
    /// The sealed keyword is used to restrict the inheritance of the class
    /// </summary>
    public sealed class SingletonEx
    {      
        /// <summary>
        /// The instance of the class is initialized to null so that the class has only one instance
        /// </summary>
        private static SingletonEx instance = null;

        /// <summary>
        /// The count variable to keep the count of class instances created
        /// </summary>
        private static int count = 0;
       
        /// <summary>
        /// Prevents a default instance of the <see cref="SingletonEx"/> class from being created.
        /// private constructor ensures that the object is not instantiated other than within the class itself.
        /// </summary>
        private SingletonEx()
        {
            count++;
            Console.WriteLine("Count value " + count.ToString());
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance returns the instance only if the instance is set to null.
        /// Public property is used to return only one instance of the class.
        /// </value>
        public static SingletonEx GetInstance
        {
            get
            {
                if (instance == null)
                {
                    //// creating the instance of the class
                    instance = new SingletonEx();
                }

                return instance;
            }
        }

        /// <summary>
        /// Prints the details as many times whenever we call the method with different instances of the class
        /// </summary>
        /// <param name="message">The message.</param>
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Prints the singleton.
        /// </summary>
        public void PrintSingleton()
        {
            SingletonEx fromPerson1 = SingletonEx.GetInstance;
            fromPerson1.PrintDetails("First person : Hi");
            SingletonEx fromPerson2 = SingletonEx.GetInstance;
            fromPerson2.PrintDetails("Second person : Hello how are you?");
            Console.ReadLine();
        }
    }
}
