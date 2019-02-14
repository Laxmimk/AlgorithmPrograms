// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommercialDataProcessing.cs" company="Bridgelabz">
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
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;   
 
    /// <summary>
    /// class commercial data processing
    /// </summary>
    public class CommercialDataProcessing
    {
        /// <summary>
        /// method to add the customer
        /// </summary>
        public void AddCustomer()
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("enter the number of shares customer has");
            int share = Convert.ToInt32(Console.ReadLine());
            if (share > 0)
            {
                ////creating the object of the customer model class
                CustomerModel customerModel = new CustomerModel();
                {
                    customerModel.Id = id;
                    customerModel.Name = name;
                    customerModel.Share = share;
                }             

                IList<CustomerModel> customers = new List<CustomerModel>();
                //// creating the object of constant class
                Constants constants = new Constants();              
                using (StreamReader stream = new StreamReader(constants.FileOfCustomers))
                {                  
                    //// reading the file
                    string json = stream.ReadToEnd();                  
                    stream.Close();                   
                    customers = JsonConvert.DeserializeObject<List<CustomerModel>>(json);
                    //// adding the new customer to the list
                    customers.Add(customerModel);
                    var convertedJson = JsonConvert.SerializeObject(customers);   
                    //// writing to a file
                    File.WriteAllText(constants.FileOfCustomers, convertedJson);
                    Console.WriteLine("new customer has been added");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid data");
            }
        }

        /// <summary>
        /// Gets all customer.
        /// </summary>
        /// <returns>Returns list of customers</returns>
        /// <exception cref="Exception">No customers available</exception>
        public IList<CustomerModel> GetAllCustomer()
        {
            Constants constants = new Constants();
            IList<CustomerModel> customers = new List<CustomerModel>();
            using (StreamReader stream = new StreamReader(constants.FileOfCustomers))
            {
                string json = stream.ReadToEnd();
                stream.Close();             
                customers = JsonConvert.DeserializeObject<IList<CustomerModel>>(json);
                if (customers == null)
                {
                    throw new Exception("No customers available");
                }
            }

            return customers;
        }

        /// <summary>
        /// Gets all companies.
        /// </summary>
        /// <returns>Returns list of company models</returns>
        public IList<CompanyModel> GetAllCompanies()
        {
            Constants constants = new Constants();
            IList<CompanyModel> companyModels = new List<CompanyModel>();
            using (StreamReader stream = new StreamReader(constants.FileOfCompany))
            {
                string json = stream.ReadToEnd();
                stream.Close();              
                companyModels = JsonConvert.DeserializeObject<List<CompanyModel>>(json);
                return companyModels;
            }
        }

        /// <summary>
        /// Buys the shares.
        /// </summary>
        public void BuyShares()
        {
            IList<CustomerModel> customerModels = this.GetAllCustomer();          
            Console.WriteLine("id" + " " + "name" + " " + "share");
            foreach (var temp in customerModels)
            {
                Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Share);
            }         

            IList<CompanyModel> companyModels = this.GetAllCompanies();
            Console.WriteLine("name" + " " + "symbol" + " " + "share" + " " + "price");
            foreach (var item in companyModels)
            {
                Console.WriteLine(item.Name + "   " + item.Symbol + "     " + item.Share + "     " + item.Price);
            }

            Console.WriteLine("Enter the name of the customer id who is buying the shares");
            int id = Convert.ToInt32(Console.ReadLine());           
        }
    }
}
