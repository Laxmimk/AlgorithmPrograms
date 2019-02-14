// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCardsUsingQueue.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class for deck of cards using queue
    /// </summary>
    public class DeckOfCardsUsingQueue
    {      
        /// <summary>
        /// Inserts the deck cards.
        /// </summary>
        /// <param name="cardArray">The card array.</param>
        public static void InsertDeckCards(string[,] cardArray)
        {
            string[] suit = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] rank = new string[] { "King", "Queen", "Jack", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10" }; 
            for (int i = 0; i < suit.GetLength(0); i++)
            {
                for (int j = 0; j < rank.GetLength(0); j++)
                {
                    // var temp = " ";
                    cardArray[i, j] = suit[i] + " " + rank[j];
                }
            }
        }

        /// <summary>
        /// Distributes the cards.
        /// </summary>
        /// <returns>returns each player cards</returns>
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
        /// Decks the cards.
        /// </summary>
        public void DeckCards()
        {
            try
            {
                string[,] cardArray = DistributeCards();
                QueueLinkedList queue = new QueueLinkedList();
                queue = Utility.CardSort(cardArray);
                string[] playerName = { "Player1", "Player2", "Player3", "Player4" };
                int index = 0;
                while (queue.Count != 0)
                {
                    QueueLinkedList temp = (QueueLinkedList)queue.Dequeue();
                    Console.WriteLine(playerName[index] + " ==> ");
                    while (temp.Count != 0)
                    {
                        Console.Write(temp.Dequeue() + " \t ");
                    }

                    Console.WriteLine();
                    index++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception encountered " + e.Message);
            }
        }
    }
}
