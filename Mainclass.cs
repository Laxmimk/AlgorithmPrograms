// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mainclass.cs" company="Bridgelabz">
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
    /// a class for main method
    /// </summary>
    public class Mainclass
    {
        /// <summary>
        /// Main method 
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                string str = null;
                do
                {
                    Console.WriteLine("Enter 1 For Anagram Program");
                    Console.WriteLine("Enter 2 For Prime numbers");
                    Console.WriteLine("Enter 3 For Insertion Sort");
                    Console.WriteLine("Enter 4 For Bubble Sort");
                    Console.WriteLine("Enter 5 For Merge Sort");
                    Console.WriteLine("Enter 6 For Vending Machine");
                    Console.WriteLine("Enter 7 For Temperature");
                    Console.WriteLine("Enter 8 For Square Root");
                    Console.WriteLine("Enter 9 For Decimal to Binary");
                    Console.WriteLine("Enter 10 For Nibble");
                    Console.WriteLine("Enter 11 For Binary Search of integers");
                    Console.WriteLine("Enter 12 For Binary Search of strings");
                    Console.WriteLine("Enter 13 For Insertion Sort of integers");
                    Console.WriteLine("Enter 14 For Insertion sort of strings");
                    Console.WriteLine("Enter 15 For Bubble sort of integers");
                    Console.WriteLine("Enter 16 For Bubble sort of strings");
                    int num = Convert.ToInt32(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Anagram a = new Anagram();
                            a.StringAnagram();
                            break;
                        case 2:
                            Primenumbers p = new Primenumbers();
                            p.Isprime();
                            break;

                        case 3:
                            InsertionSort ins = new InsertionSort();
                            ins.Sortingofstrings();
                            break;
                        case 4:
                            BubbleSort bs = new BubbleSort();
                            bs.Bubblesortofint();
                            break;
                        case 5:
                            MergeSort m = new MergeSort();
                            Console.WriteLine("enter size of array");
                            int size = Convert.ToInt32(Console.ReadLine());
                            string[] words = new string[size];
                            Console.WriteLine("enter strings in to array");
                            for (int k = 0; k < size; k++)
                            {
                                words[k] = Console.ReadLine();
                            }

                            m.Sort(words);
                            Console.WriteLine("sorted array");

                            foreach (string sortedArray in words)
                            {
                                Console.WriteLine(sortedArray);
                                Console.ReadLine();
                            }

                            break;

                        case 6:
                            VendingMachine v = new VendingMachine();
                            v.CountCurrency();
                            break;
                        case 7:
                            Temperature t = new Temperature();
                            t.TemperatureConversion();
                            break;

                        case 8:
                            SquareRoot sq = new SquareRoot();
                            sq.FindSquareRoot();
                            break;

                        case 9:
                            DecimaltoBinary db = new DecimaltoBinary();
                            db.ConversionofDecimal();
                            break;

                        case 10:
                            Nibble nb = new Nibble();
                            nb.ToBinary();
                            break;
                        case 11:
                            Console.WriteLine("Enter the size of Array:");
                            int arraysize = Utility.Getinteger();
                            int[] arr = new int[arraysize];
                            Console.WriteLine("Enter " + arraysize + " Elemenets");
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                arr[i] = Utility.Getinteger();
                            }

                            Console.WriteLine("Enter an item to search:");
                            int item = Utility.Getinteger();

                            Utility.BinarySearch(arr, item);
                            break;
                        case 12:
                            Console.WriteLine("Enter the size of Array:");
                            int sizeStr = Utility.Getinteger();
                            string[] s = new string[sizeStr];
                            Console.WriteLine("Enter " + sizeStr + " Elemenets");
                            for (int i = 0; i < s.GetLength(0); i++)
                            {
                                s[i] = Utility.GetString();
                            }

                            Console.WriteLine("Enter an item to search:");
                            string itemStr = Utility.GetString();
                            Utility.BinarySearch(s, itemStr);
                            break;
                        case 13:
                            Console.WriteLine("Enter the size of Array:");
                            int sizeIns = Utility.Getinteger();
                            int[] arrIns = new int[sizeIns];
                            Console.WriteLine("Enter " + sizeIns + " Elemenets");
                            for (int i = 0; i < arrIns.GetLength(0); i++)
                            {
                                arrIns[i] = Utility.Getinteger();
                            }

                            Utility.InsertionSort(arrIns);
                            break;
                        case 14:
                            Console.WriteLine("Enter the size of Array:");
                            int strsize = Utility.Getinteger();
                            string[] strIns = new string[strsize];
                            Console.WriteLine("Enter " + strsize + " Elemenets");
                            for (int i = 0; i < strIns.GetLength(0); i++)
                            {
                                strIns[i] = Utility.GetString();
                            }

                            Utility.InsertionSort(strIns);
                            break;
                        case 15:
                            Console.WriteLine("Enter the size of Array:");
                            int sizeBubInt = Utility.Getinteger();
                            int[] arrBubInt = new int[sizeBubInt];
                            Console.WriteLine("Enter " + sizeBubInt + " Elemenets");
                            for (int i = 0; i < arrBubInt.GetLength(0); i++)
                            {
                                arrBubInt[i] = Utility.Getinteger();
                            }

                            Utility.BubbleSort(arrBubInt);
                            break;
                        case 16:
                            Console.WriteLine("Enter the size of Array:");
                            int strsizeBub = Utility.Getinteger();
                            string[] strBub = new string[strsizeBub];
                            Console.WriteLine("Enter " + strsizeBub + " Elemenets");
                            for (int i = 0; i < strBub.GetLength(0); i++)
                            {
                                strBub[i] = Utility.GetString();
                            }

                            Utility.BubbleSort(strBub);
                            break;
                    }
                }
            while(str != "n");
            Console.ReadLine();
        }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            }
            }
        }