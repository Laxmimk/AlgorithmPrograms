// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearch.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class to find the number of binary trees
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// A method Binary search tree which finds the number of binary trees by taking an input
        /// </summary>
        public void BinarySearchTree()
        {
            try
            {
                Utility u = new Utility();
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                int factorial = u.BinaryTree(number);
                int factorial1 = u.BinaryTree(number * 2);
                int factorial3 = u.BinaryTree(number + 1);
                int a = factorial1 / (factorial3 * factorial);
                Console.WriteLine("The number of binary search trees are " + a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
