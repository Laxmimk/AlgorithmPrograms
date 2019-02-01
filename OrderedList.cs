// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderedList.cs" company="Bridgelabz">
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
    using System.IO;
    using System.Collections;

    public class OrderedList
    {
        public void AscendingOrder()
        {
           
            string path = @"Laxmi2.txt";
            StreamReader sr = new StreamReader(path);
            string read = sr.ReadLine();
            sr.Close();
            LinkedList<int> linkedList = new LinkedList<int>();
            List<int> ilist = new List<int>();

            int[] filetointarray = Utility.StringtoIntArr(read);
         
            foreach (int value in filetointarray)
            {
                linkedList.AddLast(value);
            }

            Console.WriteLine("elements in linked list");
            foreach (int values in linkedList)
            {
                Console.WriteLine(values + " ");
             
            }
            Console.WriteLine();
           

            Console.WriteLine("Enter an item to search");
            int search = Utility.Getinteger();
            bool flag = false;
            foreach (int s in linkedList)
            {
                if (s == search)
                {
                    Console.WriteLine(search + " is int the list");
                    Console.WriteLine("So removing " + search);
                    linkedList.Remove(search);
                    flag = true;
                    break;
                }
            }
                if(flag == false)
                {
                    Console.WriteLine(search + " is not in the list");
                    Console.WriteLine("So adding " + search + " in list");
                    linkedList.AddLast(search);
                }
            

            //list.Sort();
            ilist = linkedList.OrderBy(c => c).ToList();
            linkedList.Clear();
            Console.WriteLine("Updated data of list is:");
            foreach (int k in ilist)
            {
                linkedList.AddLast(k);
                Console.WriteLine(k + " ");
            }
            string result = string.Empty;
            foreach(int a in linkedList)
            {
                result = result + a.ToString();
                result = result + ' ';

            }
            result = result.Trim();
            Utility.FilePathfororderedlist();
        }
    }
}
