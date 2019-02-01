// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Parantheses.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;   
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The class Paranthesis for finding whether the given expression is balanced or unbalanced
    /// </summary>
    public class Parantheses
    { 
        /// <summary>
        /// A method Balanced paranthesis for checking the conditions for balanced expression
        /// </summary>
        public void BalancedParantheses()
        {
            try
            {
                Stack stack = new Stack();
                Console.WriteLine("Enter the expression");
                string expr = Console.ReadLine();
                for (int index = 0; index < expr.Length; index++)
                {
                    if (expr[index] == '(')
                    {
                        stack.Push(expr[index]);
                    }
                    else if (expr[index] == ')')
                    {
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Expression is unbalanced");
                            Console.ReadLine();
                        }

                        stack.Pop();
                    }
                }

                if (stack.Count == 0)
                {
                    Console.WriteLine("The expression is balanced");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("the expression is not balanced");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}