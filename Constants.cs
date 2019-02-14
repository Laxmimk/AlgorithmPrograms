// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// class constants having file paths 
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// file path for inventory data management
        /// </summary>
        public readonly string InventoryManagement = @"InventoryData.json";

        /// <summary>
        /// The file path for stock report
        /// </summary>
        public readonly string FilePathForStockReport = @"Program4.json";

        /// <summary>
        /// The result for inventory management
        /// </summary>
        public readonly string ResultForInventoryManagement = @"ResultOfInventoryManagement";

        /// <summary>
        /// The file path of company 
        /// </summary>
        public readonly string FileOfCompany = @"CompanyFile.json";

        /// <summary>
        /// The file of customers
        /// </summary>
        public readonly string FileOfCustomers = @"CustomerData.json";

        /// <summary>
        /// The transaction file
        /// </summary>
        public readonly string TransactionFile = @"Transaction.json";

        /// <summary>
        /// The address book file
        /// </summary>
        public readonly string AddressBookFile = @"AddressBook.json";
    }
}