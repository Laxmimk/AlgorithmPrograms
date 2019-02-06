// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumbersAndAnagram.cs" company="Bridgelabz">
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
    /// class for prime numbers which are anagrams between the given range
    /// </summary>
    public class PrimeNumbersAndAnagram   
    {
        /// <summary>
        /// Prime numbers and anagram number in the range 0-1000.
        /// </summary>
        public void PrimeNumbersAndAnagramNumbers()
        {
            Utility u = new Utility();

            int i = 0, j, count, n;
            int[,] primeArray = new int[10, 50];
            int[,] anagramNumbers = new int[10, 50];
            for (i = 1; i < 10; i++)
            {
                primeArray[i, 0] = primeArray[i - 1, 0] + 100;
                anagramNumbers[i, 0] = anagramNumbers[i - 1, 0] + 100;
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

            for (i = 0; i < 10; i++)
            {
                count = 0;
                for (j = 1; primeArray[i, j] != 0; j++)
                {
                    for (n = j + 1; primeArray[i, n] != 0; n++)
                    {
                        if (u.Anagram(Convert.ToString(primeArray[i, j]), Convert.ToString(primeArray[i, n])))
                        {
                            count++;
                            anagramNumbers[i, count++] = primeArray[i, j];
                            anagramNumbers[i, count] = primeArray[i, n];
                        }
                    }
                }
            }

            Console.WriteLine("The prime numbers that are anagrams are: ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} - {1}", anagramNumbers[i, 0], anagramNumbers[i, 0] + 100);
                for (j = 1; anagramNumbers[i, j] != 0; j++)
                {
                    Console.Write(anagramNumbers[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
