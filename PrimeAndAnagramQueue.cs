// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAndAnagramQueue.cs" company="Bridgelabz">
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
    /// Class for finding the prime numbers which are anagram using queue
    /// </summary>
    public class PrimeAndAnagramQueue
    {
        /// <summary>
        /// Prime and anagram numbers.
        /// </summary>
        public void PrimeAndAnagramNumbers()
        {
            int[,] primenumbers = new int[10, 50];
            int i = 0, j;
            primenumbers[0, 0] = 0;
            int[,] anagram = new int[10, 20];

            PrimeAnagram pa = new PrimeAnagram();
            anagram = pa.PrimeAnagramDemo();

            PrimeAnagramClass pac;
            //// Collection Linked List
            LinkedList<PrimeAnagramClass> llpac = new LinkedList<PrimeAnagramClass>();
            //// Custom Linked list
            DoublyLinkedList llc = new DoublyLinkedList();
            for (i = 0; i < 10; i++)
            {
                pac = new PrimeAnagramClass();
                pac.SetRange(anagram[i, 0]);
                for (j = 1; anagram[i, j] != 0; j++)
                {
                    pac.SetAnagrams(anagram[i, j]);
                }

                llpac.AddFirst(pac);
                llc.Enque(pac);
            }
            //// for collection linked list
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("In range {0} - {1} ", llpac.Last.Value.GetRange().ToString(), llpac.Last.Value.GetRange() + 100);
                int[] ana = llpac.Last.Value.GetAnagrams();
                foreach (int inte in ana)
                {
                    if (inte != 0)
                    {
                        Console.Write(inte + " ");
                    }
                    else
                    {
                        break;
                    }
                }

                llpac.RemoveLast();
                Console.WriteLine();
            }

            //// for custom linked list
            Console.WriteLine("custom linked list");
            for (i = 0; i < 10; i++)
            {
                pac = (PrimeAnagramClass)llc.GetLast().GetData();
                Console.WriteLine("In range {0} - {1} ", pac.GetRange(), pac.GetRange() + 100);
                int[] ana = pac.GetAnagrams();
                foreach (int inte in ana)
                {
                    if (inte != 0)
                    {
                        Console.Write(inte + " ");
                    }
                    else
                    {
                        break;
                    }
                }

                llc.Deque();
                Console.WriteLine();
            }
        }
    }
}
