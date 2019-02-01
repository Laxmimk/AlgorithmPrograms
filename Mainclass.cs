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
