// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AnagramAndPalindrome.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections;

    /// <summary>
    /// class for finding the prime numbers which are anagram and palindrome
    /// </summary>
   public class AnagramAndPalindrome
    {
        /// <summary>
        /// Palindromes of the prime numbers.
        /// </summary>
        public void PalindromeOfPrimeNumbers()
        {
            try
            {
                Utility utility = new Utility();
                ArrayList primenumbers = utility.ListOfPrimeNumbers();
                Console.WriteLine("printing the prime numbers that are palindromes");
                ////this loop is used for retriving the elements from array list
                for (int i = 0; i < primenumbers.Count; i++)
                {
                    int result = 0;
                    int number = Convert.ToInt32(primenumbers[i]);
                    ////storing original number in temp variable
                    int temp = number;
                    if (number >= 2 && number <= 9)
                    {
                        result = number;
                    }
                    else
                    {
                        ////reversing the number and storing in result variable
                        while (number >= 1)
                        {
                            int rem = number % 10;
                            result = (result * 10) + rem;
                            number = number / 10;
                        }
                    }

                    if (result == temp)
                    {
                        Console.WriteLine(temp);
                    }
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Anagrams the of prime numbers.
        /// </summary>
        public void AnagramOfPrimeNumbers()
        {
            try
            {
                Utility utility = new Utility();
                ArrayList primenumbers = utility.ListOfPrimeNumbers();
                Console.WriteLine("printing the prime numbers that are anagram");
                ////nested for loop is used for taking the prime numbers from the array list
                for (int i = 0; i < primenumbers.Count; i++)
                {
                    ////converting number int to string
                    string number1 = primenumbers[i] + string.Empty;
                    ////converting string number in to character array
                    char[] numberInArray1 = number1.ToCharArray();
                    Array.Sort(numberInArray1);
                    ////converting character array in to string
                    string original1 = new string(numberInArray1);
                    for (int j = i + 1; j < primenumbers.Count; j++)
                    {
                        ////converting number int to string
                        string number2 = primenumbers[j] + string.Empty;
                        ////converting string number in to character array
                        char[] numberInArray2 = number2.ToCharArray();
                        Array.Sort(numberInArray2);
                        ////converting character array in to string
                        string original2 = new string(numberInArray2);
                        if (original1.Equals(original2))
                        {
                            Console.Write(number1 + "  " + number2);
                            Console.WriteLine();
                        }
                    }
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
