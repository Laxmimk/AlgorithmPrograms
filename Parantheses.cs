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
                foreach(char c in expr)
                {
                    switch(c)
                    {
                        case '(':
                            stack.Push(c);
                            break;
                        case ')':
                            stack.Pop();
                            break;
                        case '{':
                            stack.Push(c);
                            break;
                        case '}':
                            stack.Pop();
                            break;
                        case '[':
                            stack.Push(c);
                            break;
                        case ']':
                            stack.Pop();
                            break;
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