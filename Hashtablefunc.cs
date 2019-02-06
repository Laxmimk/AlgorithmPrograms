// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hashtablefunc.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// A class for hash table for searching a number from a given inputs from file
    /// </summary>
    public class Hashtablefunc
    {
        /// <summary>
        /// Hash function to search a number.
        /// </summary>
        public void HashfunctionToSearchANumber()
        {
            try
            {
                Utility u = new Utility();
               // string temp = null;
                string path = @"Hashtable.txt";
                string[] fileinputnumbers = System.IO.File.ReadAllLines(@"Hashtable.txt");
                string inputnumbers = u.StringArrayToString(fileinputnumbers).TrimEnd();
                StreamReader sr = new StreamReader(@path);
                string read = sr.ReadLine();
                sr.Close();
                int[] numbers = u.ToIntArray(inputnumbers);
                Console.WriteLine("The numbers are : ");
                foreach (int i in numbers)
                {
                    Console.WriteLine(i + " ");
                }

                Console.WriteLine();
                Hashtable ht = new Hashtable();
                foreach (int i in numbers)
                {
                    ht[i % 11] = ht[i % 11] + i.ToString() + " ";
                }

                Console.WriteLine("The hash table contains : ");
                foreach (DictionaryEntry entry in ht)

                {
                    Console.WriteLine(entry.Key + ":" + entry.Value);
                }

                Console.WriteLine();
                Console.WriteLine("Enter the number to be searched from the file");
                int searchnum = Utility.Integerof(Console.ReadLine());
                string fstr = searchnum.ToString();
                Console.WriteLine("Hash table values : " + ht[searchnum % 11].ToString().Contains(fstr));
                if (ht.ContainsKey(searchnum % 11) && ht[searchnum % 11].ToString().Contains(fstr))
                {
                   string temp = ht[searchnum % 11].ToString();
                   temp = temp.Remove(temp.LastIndexOf(fstr), fstr.Length);
                    if (temp == " " || temp.Length == 0)
                    {
                        ht.Remove(searchnum % 11);
                    }
                    else
                    {
                        ht[searchnum % 11] = temp;
                    }
                }
                else
                {
                    ht[searchnum % 11] = ht[searchnum % 11] + fstr + " ";
                }

                string resultofhashtable = string.Empty;
                string path2 = @"ResultforHashtable.txt";
                u.Fileclear(path2);
                resultofhashtable = string.Empty;
                Console.WriteLine("The hash table after the search contains : ");
                foreach (DictionaryEntry entry in ht)
                {
                    Console.WriteLine(entry.Key + ":" + entry.Value);
                }

                foreach (DictionaryEntry d in ht)
                {
                    resultofhashtable = resultofhashtable + d.Value.ToString() + " ";
                }

                string[] result = new string[] { resultofhashtable };
                System.IO.File.WriteAllLines(@"ResultforHashtable.txt", result);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
