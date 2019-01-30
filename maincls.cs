// --------------------------------------------------------------------------------------------------------------------
// <copyright file="maincls.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Mainclass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// a class Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main method 
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                string str = null;
                do
                {
                    Console.WriteLine("Enter 1 For Days of a week");
                    Console.WriteLine("Enter 2 For To guess a number");
                    Console.WriteLine("Enter 3 For monthly payment");
                    int num = Convert.ToInt32(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Utility u = new Utility();
                            int x = Convert.ToInt32(args[0]);
                            int y = Convert.ToInt32(args[1]);
                            int z = Convert.ToInt32(args[2]);
                            u.DaysOfAWeek(x, y, z);
                            break;

                        case 2:
                            Findthenumber fn = new Findthenumber();
                            int d = Convert.ToInt32(args[0]);
                            fn.Guessnumber(d);
                            break;
                        case 3:
                            MonthlyPayment mp = new MonthlyPayment();
                            double p = Convert.ToDouble(args[0]);
                            double q = Convert.ToDouble(args[1]);
                            int r = Convert.ToInt32(args[2]);
                            mp.CalculationofMonthlypayment(p, q, r);
                            break;
                        default:
                            Console.WriteLine("Please enter the valid input");
                            Console.ReadLine();
                            break;
                    }
                }
                while (str != "n");
                Console.ReadLine();
            }
                    
                
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}