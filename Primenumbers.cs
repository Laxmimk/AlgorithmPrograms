// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Primenumbers.cs" company="Bridgelabz">
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
    /// To find the prime numbers between 1 to 1000
    /// </summary>
    public class Primenumbers
    {
        /// <summary>
        /// a method for finding a prime numbers 
        /// </summary>
        public void Isprime()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers are : ");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write("\t" + i);
                }

                isPrime = true;
            }

            Console.ReadLine();
        }
    }
}
