// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearch.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.IO;

    public class BinarySearch
    {
        public string[] ReadFile()
        {
            string[] st = new string[10];
            try
            {
                string path = @"C:\Users\Admin\Desktop\New folder\Laxmi.txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    int i = 0;
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        st[i] = s;
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return st;
        }
    }
}
