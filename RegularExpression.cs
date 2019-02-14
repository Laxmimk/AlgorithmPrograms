// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegularExpression.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OopsPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// class for regular expression using regex
    /// </summary>
    public class RegularExpression
    {
        /// <summary>
        /// Shows the match.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="expr">The expr.</param>
        /// <param name="pattern">The pattern.</param>
        /// <returns>returns a new string</returns>
        public static string ShowMatch(string text, string expr, string pattern)
        {
            Regex rgx = new Regex(pattern);
            string newString = rgx.Replace(text, expr);
            return newString;
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public void Operation()
        {
            this.ReadData();
        }

        /// <summary>
        /// Retrieves the information.
        /// </summary>
        /// <param name="fname">The f name.</param>
        /// <param name="lname">The l name.</param>
        /// <param name="mno">The m n o.</param>
        /// <param name="date">The date.</param>
        public void RetrieveInfo(string fname, string lname, string mno, string date)
        {
            try
            {
                string message = "Hello <<name>>, We have your full name as <<full name>> in our system your contact number is <<91-xxxxxxxxx>>, Please,let us know in case of any clarification Thank you BridgeLabz <<dd/mm/yyyy>>.";
                string patternForName = "<<name>>";
                message = RegularExpression.ShowMatch(message, fname, patternForName);
                string patternForfame = "<<full name>>";
                message = RegularExpression.ShowMatch(message, fname + " " + lname, patternForfame);
                string contactNumber = "<<91-xxxxxxxxx>>";
                message = RegularExpression.ShowMatch(message, "91" + " " + mno, contactNumber);
                string currentdate = "<<dd/mm/yyyy>>";
                DateTime today = DateTime.Today;
                message = RegularExpression.ShowMatch(message, today.ToString(), currentdate);
                Console.WriteLine(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Reads the data.
        /// </summary>
        public void ReadData()
        {
            try
            {
                Console.WriteLine("Enter your First name");
                string fname = Utility.IsString(Console.ReadLine());
                Console.WriteLine("Enter your Last name");
                string lname = Utility.IsString(Console.ReadLine());
                Console.WriteLine("Enter your mobile number");
                string mobileno = Console.ReadLine();               
                    DateTime thisDay = DateTime.Today;
                    string date = thisDay.ToString("d");
                    if (Regex.IsMatch(mobileno, @"[0-9]{10}") && Regex.IsMatch(fname, @"[a-zA-z]") && Regex.IsMatch(lname, @"[a-zA-z]"))
                    {
                        this.RetrieveInfo(fname, lname, mobileno, date);
                    }
                    else
                    {
                        Console.WriteLine("Data is invalid,Try again");
                    }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
