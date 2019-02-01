// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
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
    /// A utility class 
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// A method to convert to integer of 32 bits
        /// </summary>
        /// <returns>Returns an integer value</returns>
        public static int Getinteger()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        /// <summary>
        /// A method for converting a string to integer array
        /// </summary>
        /// <param name="read">The read.</param>
        /// <returns>Returns an array</returns>
        public static int[] StringtoIntArr(string read)
        {
            int count = 0, temp = 0, i = 0;
            foreach (char c in read)
            {
                if (c == ' ')
                {
                    count++;
                }
            }

                int[] filetointarray = new int[count + 1];
                foreach (char s in read)
                {
                    if (s != ' ')
                    {
                        temp = (temp * 10) + Convert.ToInt32(s.ToString());
                    }
                    else
                    {
                        filetointarray[i++] = temp;
                        temp = 0;
                    }
                }
            
                filetointarray[i] = temp;
                Console.WriteLine();
                return filetointarray;           
        }

        /// <summary>
        /// A method for giving a path of the file for unordered list
        /// </summary>
        /// <returns>Returns the path of a file</returns>
        public static string FilePathUnordered()
        {
            string path = null;
            try
            {
                path = @"Laxmi.txt";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return path;
        }

        /// <summary>
        /// A method for giving a path of a file
        /// </summary>
        /// <returns>Returns a path of a file</returns>
        public static string FilePathfororderedlist()
        {
            string path = null;
            try
            {
                path = @"Laxmi2.txt";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return path;
        }
    }
}
