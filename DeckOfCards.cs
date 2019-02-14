// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCards.cs" company="Bridgelabz">
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
    /// class for deck of cards
    /// </summary>
    public class DeckOfCards
    {
        /// <summary>
        /// method for inserting the cards
        /// </summary>
        /// <param name="cardArray">The card array.</param>
        public static void InsertDeckCards(string[,] cardArray)
        {
            try
            {
                string[] suit = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
                string[] rank = new string[] { "King", "Queen", "Jack", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
                for (int i = 0; i < suit.GetLength(0); i++)
                {
                    for (int j = 0; j < rank.GetLength(0); j++)
                    {
                        cardArray[i, j] = suit[i] + " " + rank[j];
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The msg is" + e.Message);
            }
        }

        /// <summary>
        /// Distributes the cards.
        /// </summary>
        /// <returns>return the cards for each player</returns>
        public static string[,] DistributeCards()
        {
            string[,] distributecards = new string[4, 13];
            InsertDeckCards(distributecards);
            ShuffleDeckCards(distributecards);
            string[,] eachPlayerCards = new string[4, 9];
            for (int i = 0; i < eachPlayerCards.GetLength(0); i++)
            {
                for (int j = 0; j < eachPlayerCards.GetLength(1); j++)
                {
                    eachPlayerCards[i, j] = distributecards[i, j];
                }
            }

            return eachPlayerCards;
        }

        /// <summary>
        /// Shuffles the deck cards.
        /// </summary>
        /// <param name="cardsArray">The cards array.</param>
        public static void ShuffleDeckCards(string[,] cardsArray)
        {
            Random rd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int w = Convert.ToInt32(rd.Next(4));
                int x = Convert.ToInt32(rd.Next(13));
                int y = Convert.ToInt32(rd.Next(4));
                int z = Convert.ToInt32(rd.Next(13));
                SwapCards(cardsArray, w, x, y, z);
            }
        }

        /// <summary>
        /// Swaps the cards.
        /// </summary>
        /// <param name="cardsArray">The cards array.</param>
        /// <param name="w">The w.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        public static void SwapCards(string[,] cardsArray, int w, int x, int y, int z)
        {
            string temp = cardsArray[w, x];
            cardsArray[w, x] = cardsArray[y, z];
            cardsArray[y, z] = temp;
        }

        /// <summary>
        /// Deck the cards.
        /// </summary>
        public void DeckCards()
        {
            try
            {
                string[,] cardArray = DistributeCards();
                int x = 0;
                int y = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.WriteLine(cardArray[x, y] + "\t");
                        y++;
                        if (y == 9)
                        {
                            y = 0;
                            x++;
                        }
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}    