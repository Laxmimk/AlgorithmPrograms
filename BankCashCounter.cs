// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BankCashCounter.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// class bank cash counter for few bank operations
    /// </summary>
    public class BankCashCounter
    {
        /// <summary>
        /// the object creation for the queue
        /// </summary>
        private Queue queue = new Queue();

        /// <summary>
        /// initializing a variable to zero
        /// </summary>
        private int count = 0;

        /// <summary>
        /// Initializing the total cash to 10000
        /// </summary>
        private int totalcash = 10000;

        /// <summary>
        /// A method for various bank operations
        /// </summary>
        public void BankOperations()
        {
            try
            {
                char ch = 'n';
                do
                {
                    Console.WriteLine("Enter 1 for add customer");
                    Console.WriteLine("Enter 2 for deposit cash");
                    Console.WriteLine("Enter 3 for withdraw cash");
                    Console.WriteLine("Enter 4 for checking balance");
                    Console.WriteLine("Enter 5 to view the customers");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            this.AddCustomer();
                            break;
                        case 2:
                            this.DepositeCash();
                            break;
                        case 3:
                            this.WithdrawCash();
                            break;
                        case 4:
                            this.CheckBalance();
                            break;
                        case 5:
                            this.ViewCustomer();
                            break;
                        default:
                            Console.WriteLine("Enter the proper number");
                            break;
                    }
                }
                while (ch != 'n');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// A method to add a customer to a queue
        /// </summary>
        public void AddCustomer()
        {
            try
            {
                Console.WriteLine("Enter the number of Customers");
                int customer = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= customer; i++)
                {
                    this.count++;
                    Console.WriteLine("Enter " + i + " name");
                    string name = Console.ReadLine();
                    this.queue.Enqueue(name);
                }

                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// a method to deposit a cash
        /// </summary>
        public void DepositeCash()
        {
            try
            {
                Console.WriteLine("Enter the amount to be deposited");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount > 0)
                {
                    this.totalcash = this.totalcash + amount;
                    Console.WriteLine(amount + " Amount added");
                    Console.WriteLine("The total cash is " + this.totalcash);
                    this.queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Enter the valid input");
                }

                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// A method to withdraw a cash
        /// </summary>
        public void WithdrawCash()
        {
            try
            {
                Console.WriteLine("Enter the amount to be withdrawn");
                int withdrawcash = Convert.ToInt32(Console.ReadLine());
                if (withdrawcash > 0 && withdrawcash != this.totalcash)
                {
                    this.totalcash = this.totalcash - withdrawcash;
                    Console.WriteLine(withdrawcash + " Amount withdrawn");
                    Console.WriteLine("The total cash after the withdrawl is " + this.totalcash);
                    this.queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Enter the proper amount");
                    Console.ReadLine();
                }

                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Method to check the balance
        /// </summary>
        public void CheckBalance()
        {
            try
            {
                Console.WriteLine("The balance is " + this.totalcash);
                Console.ReadLine();
                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// A method to view the customers in a queue
        /// </summary>
        public void ViewCustomer()
        {
            try
            {
                if (this.queue != null)
                {
                    foreach (string customer in this.queue)
                    {
                        Console.WriteLine(customer);
                    }
                }
                else
                {
                    Console.WriteLine("There is no one in the queue");
                    Console.ReadLine();
                }

                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
