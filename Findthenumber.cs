// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Findthenumber.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Mainclass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// to guess a number 
    /// </summary>
    public class Findthenumber
    {
        /// <summary>
        /// a method to guess the number
        /// </summary>
        /// <param name="n">The n.</param>
        public void Guessnumber(int n)
        {
            try
            { 
            Utility utility = new Utility();
            int number = (int)Math.Pow(2, n);
            int[] array = new int[number];
            ////this loop is used for storing the elements in to an array
            for (int i = 0; i <= number - 1; i++)
            {
                array[i] = i;
            }

            Console.WriteLine("guess the number between 0 and " + (number - 1));
            int firstIndex = 0;
            int lastIndex = number - 1;
            bool correct;
            ////this variable is used to check wheter the given number is greater than or less than the middle number
            bool highOrLow;
            ////this loop is used for checking each and every element in an array between first and last index
            while (firstIndex <= lastIndex)
            {
                int middle = (firstIndex + lastIndex) / 2;
                Console.WriteLine("press enter");
                Console.ReadLine();
                Console.WriteLine("you number is " + array[middle] + " if yes enter true,else false");

                correct = Convert.ToBoolean(Console.ReadLine());
                ////this condition is used to check whether the guess number is true 
                if (correct == true)
                {
                    Console.WriteLine("your guessed number is " + array[middle]);
                    break;
                }

                Console.WriteLine("is your number is greater than " + array[middle] + " is yes enter true,else enter false");
                highOrLow = Convert.ToBoolean(Console.ReadLine());
                ////this loop is used for checking whether the given number is greater than or less than the middle number
                if (highOrLow)
                {
                    firstIndex = middle + 1;
                }
                else
                {
                    lastIndex = middle - 1;
                }
            }
        }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
}
        }
    }