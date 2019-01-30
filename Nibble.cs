// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Nibble.cs" company="Bridgelabz">
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
    /// to convert a decimal number to binary number
    /// </summary>
    public class Nibble
    {
        /// <summary>
        /// a method for the conversion
        /// </summary>
        public void ToBinary()
        {
            try
            {
                Utility utility = new Utility();
                string binaryNumber = utility.Conversionofdectobinary();
                ////if condition is used for converting the binary number in to 8 bits
                if (binaryNumber.Length < 8)
                {
                    while (binaryNumber.Length < 8)
                    {
                        binaryNumber = 0 + binaryNumber;
                    }
                }

                string nibble1 = binaryNumber.Substring(0, 4);
                string nibble2 = binaryNumber.Substring(4);
                string newBinaryNumber = nibble2 + nibble1;
                int newDecimalNumber = 0;
                int index = 0;
                ////this for loop is used for converting binary number in to decimal number
                for (int i = newBinaryNumber.Length - 1; i >= 0; i--)
                {
                    string numberInCharForm = newBinaryNumber[index] + string.Empty;
                    int number = Convert.ToInt32(numberInCharForm);
                    index++;
                    newDecimalNumber = (int)((number * Math.Pow(2, i)) + newDecimalNumber);
                }
                //// added code in binary
                Console.WriteLine("new decimal number is " + newDecimalNumber);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
