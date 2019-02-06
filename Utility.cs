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
    using System.IO;    
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
        /// a method to parse a string to integer
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>parsed string</returns>
        public static int Integerof(string str)
        {
            int p;
            //// parsing the string to 32 bit integer format
            if (int.TryParse(str, out p))
            {
                return Convert.ToInt32(str);
            }
            else
            {
                while (int.TryParse(str, out p) == false)
                {
                    Console.WriteLine("Enter integer number");
                    str = Console.ReadLine();
                }

                return Convert.ToInt32(str);
            }
        }

        /// <summary>
        /// Sorts the character.
        /// </summary>
        /// <param name="a">a</param>
        /// <returns>It returns the sorted character array</returns>
        public static char[] SortChar(char[] a)
        {
            int i, j;
            char temp;
            for (i = 0; i < a.Length; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            return a;
        }

        /// <summary>
        /// converting an integer to string
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>
        ///   <c>true</c> if the specified string is string; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsString(string str)
        {
            try
            {
                int i = 0;
                //// returns the value of substring present in the string
                if (str.Contains(" "))
                {
                    Console.WriteLine("Invalid input");
                    return false;
                }

                for (i = 0; i < 10; i++)
                {
                    //// converts the integer value to equivalent string format
                    if (str.Contains(i.ToString()))
                    {
                        Console.WriteLine("you have entered the wrong input");
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
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
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

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

        /// <summary>
        /// A method for the path of Hash table program
        /// </summary>
        public static void FilePathforHashtable()
        {
            string path = null;
            try
            {
                path = @"Hashtable.txt";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified input is integer.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns>It returns a integer value</returns>
        public static int IsInteger(string input, int min, int max)
        {
            int num;
            if (int.TryParse(input, out num) && (num >= min && num <= max))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                bool flag = false;
                while (flag == false)
                {
                    if (int.TryParse(input, out num) == false)
                    {
                        Console.WriteLine("Enter the valid input");
                        input = Console.ReadLine();
                    }

                    if (num < min || num > max)
                    {
                        Console.WriteLine("It is not a valid input");
                        input = Console.ReadLine();
                    }

                    flag = true;
                }
            }

            return Convert.ToInt32(input);
        }

        /// <summary>
        /// Is string the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>It returns a string value</returns>
        public static string Isstring(string input)
        {
            int flag = 1;
            do
            {
                int i = 0;
                if (input.Contains("  "))
                {
                    flag = 1;
                    Console.WriteLine("You have entered moe than 1 space, please try again");
                    input = Console.ReadLine();
                }
                //// it checks it the string has spaces
                for (i = 0; i < 10; i++)
                {
                    if (input.Contains(i.ToString()))
                    {
                        flag = 1;
                        Console.WriteLine("You have entered number in string it should not be please try again");
                        input = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
            }
            while (flag == 1);
            return input;
        }

        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="number">The number to be checked as prime</param>
        /// <returns>
        ///   <c>true</c> if the specified number is prime; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPrime(int number)
        {
            int counter;
            bool flag = true;

            switch (number)
            {
                case 0:
                    return false;
                case 1:
                    return false;
                case 2:
                    return true;
            }

            for (counter = 2; counter <= number / 2; counter++)
            {
                //// if counter is  not prime
                if (number % counter == 0)
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }

        /// <summary>
        /// Leap year the specified year.
        /// </summary>
        /// <param name="year">The year</param>
        /// <returns>It returns true if the year is leap year and false if the year is not a leap year</returns>
        public bool Leapyear(int year)
        {
            if ((year % 100) == 0)
            {
                if ((year % 400) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if ((year % 4) == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// A method to find the number of binary trees
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>Returns factorial of a number</returns>
        public int BinaryTree(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            return fact;
        }

        /// <summary>
        /// A method to convert to an integer array
        /// </summary>
        /// <returns>It returns an integer array</returns>
        public int[] IntegerArray()
        {
            int[] intArray = new int[0];
            try
            {
                FileStream hashtable = new FileStream(@"Hashtable.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(hashtable);
                string input = " ";
                string[] lines = null;            
                while (input != null)
                {
                    lines = input.Split(',');

                    Console.WriteLine("Contents of the file are : ");
                    for (int i = 0; i < 1; i++)
                    {
                        int x = int.Parse(lines[i]);
                        intArray[i] = x;
                    }

                    input = sr.ReadLine();
                }

                Console.WriteLine(intArray[0]);               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return intArray;
        }

        /// <summary>
        /// A method to find the prime numbers
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns>It returns true for prime number and false for non prime integers</returns>
        public bool Isprime(int num)
        {
            bool isPrime = true;
            try
            {
                int i;               
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return isPrime;
        }

        /// <summary>
        /// Strings the anagram.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns>It returns true or false</returns>
        public bool StringAnagram(string str1, string str2)
        {
            try
            {               
                 str1 = Console.ReadLine();
                 str2 = Console.ReadLine();
                //// converting the string to lower case and to character array
                char[] char1 = str1.ToCharArray();
                char[] char2 = str2.ToCharArray();
                //// performing the sorting on character array
                Array.Sort(char1);
                Array.Sort(char2);
                string newstr1 = new string(char1);
                string newstr2 = new string(char2);
                //// condition to check the contents of the character arrays
                if (newstr1.Equals(newstr2))
                {
                    // Console.WriteLine("Yes both the given words are Anagrams ");
                    return true;
                }
                else
                {
                    // Console.WriteLine("No They are not Anagram");
                    return false;
                }               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        /// <summary>
        /// Checks day of the week on the date provided
        /// </summary>
        /// <param name="d">The date on the day</param>
        /// <param name="m">Month in the date</param>
        /// /// <param name="y">Year in the date</param>
        /// <returns>the day of the week</returns>
        public string DaysOfAWeek(int d, int m, int y)
        {
            int y0, x, m0, d0;
            y0 = y - ((14 - m) / 12);
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            m0 = m + (12 * ((14 - m) / 12)) - 2;
            d0 = (d + x + (31 * m0 / 12)) % 7;
            string[] months = new string[]
            {
                "January", "Feb", "March", "April", "May", "June", "July", "August", "September", "October", "November",
                        "December"
            };
            string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
            return days[d0];
        }

        /// <summary>
        /// method for finding whether the given strings are anagram or not
        /// </summary>
        /// <param name="string1">The string1.</param>
        /// <param name="string2">The string2.</param>
        /// <returns>It returns true or false</returns>
        public bool Anagram(string string1, string string2)
        {
            int i, flag = 0;

            if (string1.Length == 1 || string2.Length == 1)

                if (string1.Length != string2.Length)
                {                   
                    return false;
                }

            char[] aS1 = new char[string1.Length];
            char[] aS2 = new char[string2.Length];

            for (i = 0; i < string1.Length; i++)
            {
                aS1[i] = string1[i];
            }

            for (i = 0; i < string2.Length; i++)
            {
                aS2[i] = string2[i];
            }

            aS1 = SortChar(aS1);
            aS2 = SortChar(aS2);
            for (i = 0; i < string1.Length; i++)
            {
                if (aS1[i] != aS2[i])
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Converts to integer array.
        /// </summary>
        /// <param name="read">The read.</param>
        /// <returns>It returns a array</returns>
        public int[] ToIntArray(string read)
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

            foreach (char c in read)
            {
                if (c != ' ')
                {
                    temp = (temp * 10) + Convert.ToInt32(c.ToString());
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
        /// It converts String array to string.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>It returns a string</returns>
        public string StringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder strinbuilder = new StringBuilder();
            foreach (string value in array)
            {
                strinbuilder.Append(value);
                strinbuilder.Append(' ');
            }

            return strinbuilder.ToString();
        }

        /// <summary>
        /// File clears the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        public void Fileclear(string path)
        {
            File.WriteAllText(path, " ");
        }       
    }
}
