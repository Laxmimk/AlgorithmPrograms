// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
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
    /// The class will return whether the entered strings are anagram are or not
    /// </summary>
    public class Anagram
    {
        /// <summary>
        /// this method checks the both strings and compares each other and returns the result
        /// </summary>
        public void StringAnagram()
        {
            try
            {
                Console.WriteLine("Enter the first string");
                string str1 = Console.ReadLine();
                Console.WriteLine("Enter the second string");
                string str2 = Console.ReadLine();
                //// converting the string to lower case and to character array
                char[] char1 = str1.ToLower().ToCharArray();
                char[] char2 = str2.ToLower().ToCharArray();
                //// performing the sorting on character array
                Array.Sort(char1);
                Array.Sort(char2);
                string newstr1 = new string(char1);
                string newstr2 = new string(char2);
                //// condition to check the contents of the character arrays
                if (newstr1.Equals(newstr2))
                {
                    Console.WriteLine("Yes both the given words are Anagrams ");
                }
                else
                {
                    Console.WriteLine("No They are not Anagram");
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
