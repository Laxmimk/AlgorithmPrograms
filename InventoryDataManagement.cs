// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryDataManagement.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// class for inventory management
    /// </summary>
    public class InventoryDataManagement
   {
        /// <summary>
        /// method for finding the total price of each item
        /// </summary>
        public void Inventory()
        {
            try
            {
                InventoryDataManagement idm = new InventoryDataManagement();
                Constants constant = new Constants();
                var json = File.ReadAllText(constant.InventoryManagement);
                var jsonObj = JObject.Parse(json);
                var riceArray = jsonObj.GetValue("rice") as JArray;
                var itemsArray = riceArray;
                var wheatArray = jsonObj.GetValue("wheat") as JArray;
                itemsArray.Add(wheatArray);
                var pulseArray = jsonObj.GetValue("pulses") as JArray;
                itemsArray.Add(pulseArray);
                Console.WriteLine(itemsArray);
                int m = riceArray.Count;
                int n = wheatArray.Count;
                int p = pulseArray.Count;
                for (int j = 0; j < n; j++)
                {
                    int x = Convert.ToInt32(wheatArray[j]["weight"]);
                    int y = Convert.ToInt32(wheatArray[j]["price"]);
                    Console.WriteLine("Cost of " + wheatArray[j]["name"] + " for " + wheatArray[j]["weight"] + " kg = " + (x * y));
                }

                for (int i = 0; i < m; i++)
                {
                    int value = Convert.ToInt32(riceArray[i]["weight"]);
                    int v = Convert.ToInt32(riceArray[i]["price"]);
                    Console.WriteLine("Cost of " + riceArray[i]["name"] + " for " + riceArray[i]["weight"] + " kg = " + (value * v));
                }

                for (int k = 0; k < p; k++)
                {
                    int x = Convert.ToInt32(pulseArray[k]["weight"]);
                    int y = Convert.ToInt32(pulseArray[k]["price"]);
                    Console.WriteLine("Cost of " + pulseArray[k]["name"] + " for " + pulseArray[k]["weight"] + " kg = " + (x * y));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
   }
}
