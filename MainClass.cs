// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A main class
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                ////declaring and initializing char variable
                char ch = 'y';
                ////do while loop start iterating till the user press yes
                do
                {
                    ////asking user to put there choice of program to execute
                    Console.WriteLine("Enter 1 for inventory data management");
                    Console.WriteLine("Enter 2 for regular expression");
                    Console.WriteLine("Enter 3 for Stock report");
                    Console.WriteLine("Enter 4 for Deck of cards");
                    Console.WriteLine("Enter 5 for inventory managements");
                    Console.WriteLine("Enter 6 for Commercial data processing");
                    Console.WriteLine("Enter 7 for Deck of cards using queue");
                    Console.WriteLine("Enter 8 for address book");                   
                    Console.WriteLine("Enter the question number to get the output");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    ////swich case will directly goes to that chosen program and start execution of that program
                    switch (choice)
                    {
                        case 1:
                            InventoryDataManagement inventoryDataManagement = new InventoryDataManagement();
                            inventoryDataManagement.Inventory();
                            break;
                        case 2:
                            RegularExpression re = new RegularExpression();
                            re.ReadData();
                            break;
                        case 3:
                            StockReport sr = new StockReport();
                            sr.PrintReport();
                            break;
                        case 4:
                            DeckOfCards cards = new DeckOfCards();
                            cards.DeckCards();
                            break;
                        case 5:
                            InventoryManagementPgm5 inventoryManagement = new InventoryManagementPgm5();
                            Console.WriteLine("Choose Your Options : 1 - Add, 2 - Delete");
                            var option = Console.ReadLine();
                            switch (option)
                            {
                                case "1":
                                    inventoryManagement.AddItems();
                                    break;
                                case "2":
                                    inventoryManagement.DeleteItems();
                                    break;                                                      
                                default:
                                    Main(null);
                                    break;
                            }   
                            
                            break;
                        case 6:
                            CommercialDataProcessing comDataProcessing = new CommercialDataProcessing();
                            Console.WriteLine("Choose Your Options : 1 - Add customer, 2 - Buy shares");
                            var temp = Console.ReadLine();
                            switch (temp)
                            {
                                case "1":
                                    comDataProcessing.AddCustomer();
                                    break;
                                case "2":
                                    comDataProcessing.BuyShares();
                                    break;                              
                                default:
                                    Main(null);
                                    break;
                            }

                            break;
                        case 7:
                            DeckOfCardsUsingQueue deckOfCardsUsingQueue = new DeckOfCardsUsingQueue();
                            deckOfCardsUsingQueue.DeckCards();
                            break;
                        case 8:
                            AddressBook addressBook = new AddressBook();
                            addressBook.BookDetails();
                            break;                        
                        default:
                            Console.WriteLine("Provide Data in Range");
                            break;
                    }

                    Console.WriteLine("Do you want to continue (y/n)");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch != 'n');
                Console.WriteLine("Enter the proper input");
            }
            catch (Exception e)
            {               
                Console.WriteLine(e.Message);
            }

           // Console.ReadLine();
        }
    }
}
