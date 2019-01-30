// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections;
    using System.Diagnostics;

    /// <summary>
    /// a utility class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// creating an object of the stopwatch
        /// </summary>
        private Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// converting the given number to integer of 32 bit
        /// </summary>
        /// <returns >Returns an integer value</returns>
       public static int Getinteger()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        /// <summary>
        /// a method for validating a string
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string GetString()
        {
            string i = null;
            try
            {
                i = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return i;
        }

        /// <summary>
        /// A method to convert the given number to the double
        /// </summary>
        /// <returns> Returns a double value</returns>
        public static double Getdouble()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }

        /// <summary>
        /// A method to find the prime numbers
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if the specified n is prime; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPrime(int n)
        {
            try
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
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
        /// a method to parse a string to integer
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>parsed string</returns>
        public static bool Integerof(string str)
            {
                int p;
            //// parsing the string to 32 bit integer format
            if (int.TryParse("str", out p))
            {
                return true;
            }
            else
            {
                return false;
            }
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

                return true;
            }

        /// <summary>
        /// Binaries the search.
        /// </summary>
        /// <param name="arr">The array.</param>
        /// <param name="item">The item.</param>
        public static void BinarySearch(int[] arr, int item)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Array.Sort(arr);
                int low = 0;
                int high = arr.GetLength(0) - 1;
                int middle = (low + high) / 2;
                while (low <= high)
                {
                    if (arr[middle] == item)
                    {
                        Console.WriteLine(item + " is found at " + middle + " Position");
                        break;
                    }
                    else if (item > arr[middle])
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle - 1;
                    }

                    middle = (low + high) / 2;
                }

                if (low > high)
                {
                    Console.WriteLine(item + " Not find in the list");
                }

                stopwatch.Stop();
                Console.WriteLine("Elapsed Time: " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Binaries the search string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="item">The item.</param>
        public static void BinarySearch(string[] str, string item)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Array.Sort(str);
                int low = 0;
                int high = str.GetLength(0) - 1;
                int middle = (low + high) / 2;
                while (low <= high)
                {
                    if (str[middle].CompareTo(item) == 0)
                    {
                        Console.WriteLine(item + " Found at " + middle + " Position ");
                        break;
                    }
                    else if (str[middle].CompareTo(item) < 0)
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle + 1;
                    }

                    middle = (low + high) / 2;
                }

                if (low > high)
                {
                    Console.WriteLine(item + " is not in list of array");
                }

                stopwatch.Stop();
                Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Insertions the sort integer.
        /// </summary>
        /// <param name="arr">The array.</param>
        public static void InsertionSort(int[] arr)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int temp, j;
                for (int i = 1; i < arr.GetLength(0); i++)
                {
                    temp = arr[i];
                    j = i;
                    while (j > 0 && arr[j - 1] > temp)
                    {
                        arr[j] = arr[j - 1];
                        j = j - 1;
                    }

                    arr[j] = temp;
                }

                Console.WriteLine("Sorted Arrays are:");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    Console.Write(arr[i] + " ");
                }

                Console.WriteLine();
                stopwatch.Stop();
                Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Insertions the sort string.
        /// </summary>
        /// <param name="str">The string.</param>
        public static void InsertionSort(string[] str)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string temp;
                int j;
                for (int i = 1; i < str.GetLength(0); i++)
                {
                    temp = str[i];
                    j = i;
                    while (j > 0 && string.Compare(str[j - 1], temp, true) > 0)
                    {
                        str[j] = str[j - 1];
                        j = j - 1;
                    }

                    str[j] = temp;
                }

                Console.WriteLine("Sorted Strings are:");
                for (int k = 0; k < str.GetLength(0); k++)
                {
                    Console.Write(str[k] + " ");
                }

                Console.WriteLine();
                stopwatch.Stop();
                Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Bubbles the sort integer.
        /// </summary>
        /// <param name="arr">The array.</param>
        public static void BubbleSort(int[] arr)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < arr.GetLength(0) - i; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array is:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            stopwatch.Stop();
            Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
        }

        /// <summary>
        /// Bubbles the sort string.
        /// </summary>
        /// <param name="str">The string.</param>
        public static void BubbleSort(string[] str)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 0; i < str.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < str.GetLength(0) - i; j++)
                    {
                        if (string.Compare(str[j - 1], str[j], true) > 0)
                        {
                            string temp = str[j - 1];
                            str[j - 1] = str[j];
                            str[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted strings are:");
                for (int i = 0; i < str.GetLength(0); i++)
                {
                    Console.Write(str[i] + " ");
                }

                Console.WriteLine();
                stopwatch.Stop();
                Console.WriteLine("ElapsedTime = " + stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// A method to find the size of an array
        /// </summary>
        /// <returns> Returns the size of the array</returns>
        public int ArraySize()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter the number of elements");
            int size = Getinteger();
            return size;
        }

        /// <summary>
        /// Bubble sort for the integers
        /// </summary>
        public void BubbleSortOfIntegers()
        {
            int size = this.ArraySize();
            Console.ReadLine();
            //// creating an integer array
            int[] numberarr = new int[size];
            Console.WriteLine("Enter the array elements");
            //// looping over an integer array 
            for (int i = 0; i < size; i++)
            {
                numberarr[i] = Getinteger();
            }
            //// for loop to point to every element in an array
            for (int i = 0; i < numberarr.Length - 1; i++)
            {
                for (int j = 0; j < numberarr.Length - 2; j++)
                {
                    //// comapring an element with its next element in an array
                    if (numberarr[j] > numberarr[j + 1])
                    {
                        //// swapping the elements
                        int temp = numberarr[j];
                        numberarr[j] = numberarr[j + 1];
                        numberarr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("The sorted array : ");
            //// for loop to print the elements of sorted array
            for (int i = 0; i <= numberarr.Length - 1; i++)
            {
                Console.WriteLine(numberarr[i]);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Insertion sort of strings
        /// </summary>
        public void InsertionsortofStrings()
        {
            try
            {
                int size = this.ArraySize();
                Console.ReadLine();
                //// declaring an array of strings
                string[] words = new string[size];
                Console.WriteLine("Enter the array elements ");
                for (int i = 0; i < size; i++)
                {
                    words[i] = Console.ReadLine();
                }

                for (int k = 1; k < words.Length - 1; k++)
                {
                    string value = words[k];
                    int index = k;
                    while (index > 0 && words[index - 1].CompareTo(value) > 0)
                    {
                        words[index] = words[index + 1];
                        index--;
                    }

                    words[index] = value;
                }

                Console.WriteLine("The sorted array is : ");
                for (int i = 0; i <= words.Length - 1; i++)
                {
                    Console.WriteLine(words[i]);
                }

                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// converting the given decimal number to a binary format
        /// </summary>
        /// <returns>Returns a binary number</returns>
      public string Conversionofdectobinary()
        {
            Console.WriteLine("Enter a decimal number");
            int decimalnumber = Getinteger();
            string binarynumber = " ";
            int temp = decimalnumber;
            //// the while loop for decimal numbers greater then zero to convert to decimal numbers
            while (decimalnumber > 0)
            {
                int rem = decimalnumber % 2;
                binarynumber = rem + binarynumber;
                decimalnumber = decimalnumber / 2;
            }  
            
            if (binarynumber.Length >= 4)
            {
                return binarynumber;
            }
            else
            {
                while (binarynumber.Length < 4)
                {     
                    //// making the length of a binary number equal to 4               
                    binarynumber = 0 + binarynumber;
                }
            }

            return binarynumber;
        }

        /// <summary>
        /// a method for finding the square root
        /// </summary>
        public void SquareRoots()
        {
            Console.WriteLine("enter number");
            double c = Getdouble();
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - (c / t)) > (epsilon * t))
            {
                t = ((c / t) + t) / 2.0;
            }

            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}