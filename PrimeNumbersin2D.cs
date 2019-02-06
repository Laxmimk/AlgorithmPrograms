// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumbersin2D.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// class for finding the prime numbers and printing them in 2D array
    /// </summary>
    public class PrimeNumbersin2D
    {
        /// <summary>
        /// Method for prime numbers
        /// </summary>
        public void Primenumbers()
        {
            Utility u = new Utility();
            
            int i = 0, j, count;
            int[,] primeArray = new int[10, 50];         
            for (i = 1; i < 10; i++)
            {
                primeArray[i, 0] = primeArray[i - 1, 0] + 100;
            }

            for (i = 0; i < 10; i++)
            {
                 count = 0;
                for (j = 1; j < 100; j++)
                {
                    if (u.Isprime(primeArray[i, 0] + j)) 
                    {
                        count++;
                        primeArray[i, count] = primeArray[i, 0] + j;
                    }
                }
            }

            Console.WriteLine("The prime numbers are: ");
                for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} - {1}: ", primeArray[i, 0], primeArray[i, 0] + 100);
                for (j = 1; primeArray[i, j] != 0; j++)
                {
                    Console.Write(primeArray[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
