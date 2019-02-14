// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    
    /// <summary>
    /// A class for address book information
    /// </summary>
    public class AddressBook
    {
        /// <summary>
        /// A method Book details
        /// </summary>
        public void BookDetails()
        {
            UtilityAddress utilityAddress = new UtilityAddress();
            //// choose an option to perform
            Console.WriteLine("Choose Your Options : 1 - Add person, 2 - Delete, 3 - Update, 4 - Sort by last name, 5 - sort by zip, 6- print address book");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    //// calling a method from address utility class
                    utilityAddress.AddPerson();
                    break;
                  
                case "2":
                    utilityAddress.DeleteData();
                    break;
                case "3":
                    utilityAddress.Update();
                    break;
                case "4":
                    utilityAddress.SortByLastName();
                    break;
                case "5":
                    utilityAddress.SortByZip();
                    break;
                case "6":
                    utilityAddress.PrintAddressBook();
                    break;               
            }           
        }
    }
}