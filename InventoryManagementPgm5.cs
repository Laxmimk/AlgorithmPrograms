// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManagementPgm5.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OopsPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// inventory management
    /// </summary>
    public class InventoryManagementPgm5
    {
        /// <summary>
        /// declaring the item
        /// </summary>
        private string item;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The weight of item
        /// </summary>
        private int weightOfItem;

        /// <summary>
        /// The price of item
        /// </summary>
        private int priceOfItem;

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>
        /// The item.
        /// </value>
        public string Item { get => this.item; set => this.item = value; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the weight of item.
        /// </summary>
        /// <value>
        /// The weight of item.
        /// </value>
       public int WeightOfItem { get => this.weightOfItem; set => this.weightOfItem = value; }

        /// <summary>
        /// Gets or sets the price of item.
        /// </summary>
        /// <value>
        /// The price of item.
        /// </value>
        public int PriceOfItem { get => this.priceOfItem; set => this.priceOfItem = value; }       

        /// <summary>
        /// method for adding items 
        /// </summary>
        public void AddItems()
        {
            Constants constants = new Constants();
            InventoryDataManagement invDataManagement = new InventoryDataManagement();
            var json = File.ReadAllText(constants.InventoryManagement);
            var jsonObj = JObject.Parse(json);
            var riceArray = jsonObj.GetValue("rice") as JArray;
            var wheatArray = jsonObj.GetValue("wheat") as JArray;
            var pulseArray = jsonObj.GetValue("pulses") as JArray;
            Console.WriteLine("Add the items");
            Console.WriteLine("Enter the item type whether it is rice, wheat or pulses");
            this.Item = Utility.IsString(Console.ReadLine());
            Console.WriteLine("Enter the name");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter the weight of the item");
            this.WeightOfItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price per kg of the item");
            this.PriceOfItem = Convert.ToInt32(Console.ReadLine());
            if (this.Item.Equals("rice"))
            {
                var newRiceItem = "{ 'name': " + this.Name + ", 'weight': '" + this.WeightOfItem + ", 'price': '" + this.PriceOfItem + " }";
                riceArray.Add(newRiceItem);
                Console.WriteLine(riceArray);
            }
            else if (this.Item.Equals("wheat"))
            {
                var newWheatItem = "{ 'name': " + this.Name + ", 'weight': '" + this.WeightOfItem + ", 'price': '" + this.PriceOfItem + " }";
                wheatArray.Add(newWheatItem);
                Console.WriteLine(wheatArray);
            }
            else if (this.Item.Equals("pulses"))
            {
                var newRiceItem = "{ 'name': " + this.Name + ", 'weight': '" + this.WeightOfItem + ", 'price': '" + this.PriceOfItem + " }";
                pulseArray.Add(newRiceItem);
                Console.WriteLine(pulseArray);
            }
            else
            {
                Console.WriteLine("Enter the proper input");
            }
        }

        /// <summary>
        /// Deletes the items.
        /// </summary>
        public void DeleteItems()
        {
            Constants constants = new Constants();
            InventoryDataManagement invDataManagement = new InventoryDataManagement();
            var json = File.ReadAllText(constants.InventoryManagement);
            var jObject = JObject.Parse(json);
            var riceArray = jObject.GetValue("rice") as JArray;
            var wheatArray = jObject.GetValue("wheat") as JArray;
            var pulseArray = jObject.GetValue("pulses") as JArray;
            var itemsArray = riceArray;
            itemsArray.Add(wheatArray);
            itemsArray.Add(pulseArray);
            Console.WriteLine(itemsArray);
            Console.WriteLine("Delete the items");
            Console.WriteLine("Enter the item to be deleted ie rice, wheat or pulses");
            this.Item = Console.ReadLine();
            Console.WriteLine("Enter the item name to delete");
            this.Name = Console.ReadLine();
            if (this.Item.Equals("rice"))
            {
                var itemToDelete = riceArray.FirstOrDefault(obj => obj["name"].Value<string>().Equals(this.Name));
                riceArray.Remove(itemToDelete);
                Console.WriteLine(riceArray);
            }
            else if (this.Item.Equals("wheat"))
            {
                var itemToDelete = wheatArray.FirstOrDefault(obj => obj["name"].Value<string>().Equals(this.Name));
                wheatArray.Remove(itemToDelete);
                Console.WriteLine(wheatArray);
            }

            if (this.Item.Equals("pulses"))
            {
                var itemToDelete = pulseArray.FirstOrDefault(obj => obj["name"].Value<string>().Equals(this.Name));
                pulseArray.Remove(itemToDelete);
                Console.WriteLine(pulseArray);
            }
            else
            {
                Console.WriteLine("Enter the valid input");
            }
        }      
    }
}
