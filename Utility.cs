// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
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
    /// class for utility
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Strings to string array.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>returns string array</returns>
        public static string[] StringToStringArray(string s)
        {
                int count = 0, i = 0;
                foreach (char c in s)
                {
                    if (c == ' ')
                    {
                        count++;
                    }
                }

                string[] stringarray = new string[count + 1];
                string temp = string.Empty;
                foreach (char c in s)
                {
                    //// if space is encountered we store it to next element
                    if (c == ' ')
                    {
                        stringarray[i] = temp;
                        temp = string.Empty;
                        i++;
                    }
                    else
                    {
                        temp = temp + c;
                    }

                    stringarray[i] = temp;
                }

                return stringarray;
        }

        /// <summary>
        /// converting an integer to string
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>
        ///   <c>true</c> if the specified string is string; otherwise, <c>false</c>.
        /// </returns>
        public static string IsString(string str)
        {
            int i = 0;
            //// returns the value of substring present in the string
            if (str.Contains(" "))
            {
                Console.WriteLine("Invalid input");               
            }

            for (i = 0; i < 10; i++)
            {
                //// converts the integer value to equivalent string format
                if (str.Contains(i.ToString()))
                {
                    Console.WriteLine("you have entered the wrong input");
                }
            }

            return str;
        }

        /// <summary>
        /// sort the cards
        /// </summary>
        /// <param name="playercard">The player card.</param>
        /// <returns>returns player cards</returns>
        public static QueueLinkedList CardSort(string[,] playercard)
        {
           QueueLinkedList sortedcard = new QueueLinkedList();

            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] arr = new int[9];
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string[] temp = Utility.StringToStringArray(playercard[i, j] + " ");
                    for (int k = 0; k < 13; k++)
                    {
                        if (temp[1].Equals(rank[k]))
                        {
                            arr[index] = k;
                            index++;
                        }
                    }
                }

                Console.WriteLine();
                index = 0;
                for (int k1 = 0; k1 < arr.Length - 1; k1++)
                {
                    for (int k2 = k1 + 1; k2 < arr.Length; k2++)
                    {
                        if (arr[k1] > arr[k2])
                        {
                            int temp = arr[k1];
                            arr[k1] = arr[k2];
                            arr[k2] = temp;

                            string temp1 = playercard[i, k1];
                            playercard[i, k1] = playercard[i, k2];
                            playercard[i, k2] = temp1;
                        }
                    }
                }
            }

            for (int i = 0; i < playercard.GetLength(0); i++)
            {
                QueueLinkedList temp = new QueueLinkedList();
                for (int j = 0; j < playercard.GetLength(1); j++)
                {
                    temp.Enqueue(Convert.ToInt32(playercard[i, j]));
                }

                sortedcard.Enqueue(Convert.ToInt32(temp));
            }

            return sortedcard;
        }
    }
}
