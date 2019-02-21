// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using DesignPattern.AdapterDesignPattern1;
    using DesignPattern.AdapterDesignPattern2;
    using DesignPattern.DependencyInjection;
    using DesignPattern.FacadeDesignPattern;
    using DesignPattern.FactoryDesignPattern;
    using DesignPattern.MediatorDesignPattern;
    using DesignPattern.ObserverDesignPatternEx1;
    using DesignPattern.ObserverDesignPatternEx2;
    using DesignPattern.ProxyDesignPattern;
    using DesignPattern.Reflection;
    using DesignPattern.Singleton;
    using DesignPattern.VisitorDesignPattern;

    /// <summary>
    /// A main class
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// A main method
        /// </summary>
        /// <param name="args">String arguments</param>
        public static void Main(string[] args)
        {
            try
            {
                ////declaring and initializing char variable
                char ch = 'y';
                int choice = 0;
                ////do while loop start iterating till the user press yes
                do
                {
                    ////asking user to put there choice of program to execute
                    Console.WriteLine("Enter 1 to execute Singleton design pattern example ");
                    Console.WriteLine("Enter 2 to execute Factory design pattern");
                    Console.WriteLine("Enter 3 to execute Adapter design pattern for third party billing system");
                    Console.WriteLine("Enter 4 to execute Vendor adapter using Adapter design pattern");
                    Console.WriteLine("Enter 5 to execute facade design pattern");
                    Console.WriteLine("Enter 6 for proxy design pattern");
                    Console.WriteLine("Enter 7 for Observer design pattern");
                    Console.WriteLine("Enter 8 for Observer design pattern for stock deatils");
                    Console.WriteLine("Enter 9 for Visitor design pattern");
                    Console.WriteLine("Enter 10 for Mediator design pattern");
                    Console.WriteLine("Enter 11 for Dependency injection example");
                    Console.WriteLine("Enter 12 for Factory design pattern using reflection");
                    Console.WriteLine("Enter the question number to get the output");

                    try
                    {
                         choice = Convert.ToInt32(Console.ReadLine());
                    }
                     catch (Exception e)
                    {
                        Console.WriteLine("Please enter the numbers only : " + e.Message);
                    }
                    ////swich case will directly goes to that chosen program and start execution of that program
                    switch (choice)
                    {
                        case 1:
                            SingletonEx singletonEx = SingletonEx.GetInstance;
                            singletonEx.PrintSingleton();
                            break;
                        case 2:
                            ConcreteVehicleFactory concreteVehicleFactory = new ConcreteVehicleFactory();
                            concreteVehicleFactory.PrintMethod();
                            break;
                        case 3:
                            ITarget Itarget = new EmployeeAdapter();
                            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
                            client.ShowEmployeeList();
                            break;
                        case 4:
                            VendorAdapter vendorAdapter = new VendorAdapter();
                            vendorAdapter.PrintItems();
                            break;
                        case 5:
                            CarFacade carFacade = new CarFacade();
                            carFacade.CreateCompleteCar();
                            break;
                        case 6:
                            MathProxy mathProxy = new MathProxy();
                            mathProxy.PrintProxy();
                            break;
                        case 7:
                            PrintVeggies printVeggies = new PrintVeggies();
                            printVeggies.PrintDetails();
                            break;
                        case 8:
                            StockDetails stockDetails = new StockDetails();
                            stockDetails.PrintStockDetails();
                            break;
                        case 9:
                            PrintVisitor printVisitor = new PrintVisitor();
                            printVisitor.PrintDetailsOfVisitor();
                            break;
                        case 10:
                            PrintMediator printMediator = new PrintMediator();
                            printMediator.PrintMediatorDetails();
                            break;
                        case 11:
                            PrintConstructor printConstructor = new PrintConstructor();
                            printConstructor.ConstructorPrint();
                            break;
                        case 12:
                            PrintReflection printReflection = new PrintReflection();
                            printReflection.ReflectionDetails();
                            break;
                        default:
                            Console.WriteLine(" ");
                            break;
                    }

                    Console.WriteLine("Do you want to continue (y/n)");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch != 'n');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
