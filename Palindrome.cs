// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Palindrome.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// class Palindrome to check whether the given string is palindrome or not
    /// </summary>
    public class Palindrome
    {
        /// <summary>
        /// A method to check the palindrome of a string
        /// </summary>
        public void PalindromeChecker()
        {
            //// 1st queue object creation 
            Queue queue1 = new Queue();
            //// 2nd queue object creation
            Queue queue2 = new Queue();
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            if (str.Contains(" "))
            {
                Console.WriteLine("Enter the proper input");
                Console.ReadLine();
            }
            else
            {
                int flag = 0;
                //// converting the given string to character array
                char[] c = str.ToCharArray();
                for (int i = 0; i < c.Length; i++)
                {
                    queue1.Enqueue(c[i]);
                }

                for (int j = c.Length - 1; j >= 0; j--)
                {
                    queue2.Enqueue(c[j]);
                }

                while ((queue1.Count != 0) && (queue2.Count != 0))
                {
                    if ((char)queue1.Dequeue() != (char)queue2.Dequeue())
                    {
                        flag++;
                    }
                }

                if (flag > 0)
                {
                    Console.WriteLine(str + " is not a palindrome");
                }
                else
                {
                    Console.WriteLine(str + " is a palindrome");
                }
            }
        }
    }
}
