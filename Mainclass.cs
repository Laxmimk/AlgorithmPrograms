// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mainclass.cs" company="Bridgelabz">
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
    /// A main class
    /// </summary>
    public class Mainclass
    {
        /// <summary>
        /// A main method
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                ////declaring and initializing char variable
                char ch = 'y';
                ////do while loop start iterating till the user press yes
                do
                {
                    ////asking user to put there choice of program to execute
                    Console.WriteLine("Enter 1 to execute Unordered List ");
                    Console.WriteLine("Enter 2 for ordered list");
                    Console.WriteLine("Enter 3 for balanced parantheses");
                    Console.WriteLine("Enter 4 for bank cash counter");
                    Console.WriteLine("Enter 5 for Palindrome");
                    Console.WriteLine("Enter 6 for Calendar using queue");
                    Console.WriteLine("Enter 7 for binary search tree");
                    Console.WriteLine("Enter 8 for Prime numbers in 2D array");
                    Console.WriteLine("Enter 9 for Prime numbers that are anagram");
                    Console.WriteLine("Enter 10 for Hash table function");
                    Console.WriteLine("Enter 11 for prime numbers and anagrams using stack");
                    Console.WriteLine("Enter 12 for calendar using stack");
                    Console.WriteLine("Enter 13 for prime and anagram using queue");
                    Console.WriteLine("Enter the question number to get the output");
                    
                    int choice = Convert.ToInt32(Console.ReadLine());
                    ////swich case will directly goes to that chosen program and start execution of that program
                    switch (choice)
                    {
                        case 1:
                            UnorderedList unordered = new UnorderedList();
                            unordered.UnOrderedOperations();
                            break;
                        case 2:
                            OrderedList ol = new OrderedList();
                            ol.AscendingOrder();
                            break;
                        case 3:
                            Parantheses p = new Parantheses();
                            p.BalancedParantheses();
                            break;
                        case 4:
                            BankCashCounter bcc = new BankCashCounter();
                            bcc.BankOperations();
                            break;
                        case 5:
                            Palindrome pd = new Palindrome();
                            pd.PalindromeChecker();
                            break;
                        case 6:
                            CalendarUsingQueue cq = new CalendarUsingQueue();
                            cq.CalenderLinkedlistDemo();
                            break;
                        case 7:
                            BinarySearch bs = new BinarySearch();
                            bs.BinarySearchTree();
                            break;
                        case 8:
                            PrimeNumbersin2D pn = new PrimeNumbersin2D();
                            pn.Primenumbers();
                            break;
                        case 9:
                            PrimeNumbersAndAnagram pna = new PrimeNumbersAndAnagram();
                            pna.PrimeNumbersAndAnagramNumbers();
                            break;
                        case 10:
                            Hashtablefunc hf = new Hashtablefunc();
                            hf.HashfunctionToSearchANumber();
                            break;
                        case 11:
                            PrimeAndAnagramStack pas = new PrimeAndAnagramStack();
                            pas.PrimeAndAnagramNumbers();
                            break;
                        case 12:
                            CalendarStack cs = new CalendarStack();
                            cs.CalenderStackDemo();
                            break;
                        case 13:
                            PrimeAndAnagramQueue pq = new PrimeAndAnagramQueue();
                            pq.PrimeAndAnagramNumbers();
                            break;
                        default:
                            Console.WriteLine("Provide Data in Range");
                            break;
                    }

                    Console.WriteLine("Do you want to continue (y/n)");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch != 'n');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
