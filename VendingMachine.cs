// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
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
    /// to find the fewest notes to be returned for vending machine
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// a method for finding the number of notes
        /// </summary>
        public void CountCurrency()
        {
            try
            {
                int count = 0;
                int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
                Console.WriteLine("Enter amount");
                int amount = Utility.Getinteger();
                ////for loop is used for finding the number of notes to be given as change
                for (int i = 0; i < notes.Length; i++)
                {
                    while ((amount / notes[i] > 0) && amount >= 1)
                    {
                        int change = amount / notes[i];
                        Console.WriteLine("number of " + notes[i] + " is " + change);
                        count = count + change;
                        amount = amount % notes[i];
                    }
                }

                Console.WriteLine("minimum number of notes required to give change is " + count);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
