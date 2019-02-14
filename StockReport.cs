// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockReport.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OopsPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// stock report class
    /// </summary>
    public class StockReport
    {
        /// <summary>
        /// Prints the report.
        /// </summary>
        public void PrintReport()
        {
            StockReport stockReport = new StockReport();
            Constants constants = new Constants();
            var json = File.ReadAllText(constants.FilePathForStockReport);
            var jsonObj = JObject.Parse(json);
            var stockArray = jsonObj.GetValue("stock") as JArray;
            int n = stockArray.Count;
            int i = 0;
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(stockArray[i]["numberOfShares"]);
                int y = Convert.ToInt32(stockArray[i]["sharePrice"]);
                Console.WriteLine("The total value of stock of " + stockArray[i]["name"] + " is : " + (x * y));
                sum += x * y;
            }

            Console.WriteLine("The total value of the stock is " + sum);          
        }
    }
}
