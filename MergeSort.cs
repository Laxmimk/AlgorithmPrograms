// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeSort.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// a class to find the merge sort 
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// the length variable
        /// </summary>
        private int length;

        /// <summary>
        /// The array
        /// </summary>
        private string[] array;

        /// <summary>
        /// The temporary merge array
        /// </summary>
        private string[] tempMergeArray;

        /// <summary>
        /// Sorts the specified input array.
        /// </summary>
        /// <param name="inputArray">The input</param>
        public void Sort(string[] inputArray)
        {
            ////initialising instance array and variable
            this.array = inputArray;
            this.length = inputArray.Length;
            this.tempMergeArray = new string[this.length];
            ////calling method recursively to sort all the data
            this.DivideArray(0, this.length - 1);
        }

        /// <summary>
        /// this method will divide the array in parts
        /// </summary>
        /// <param name="lowerIndex">it will take lower index of the array</param>
        /// <param name="higherIndex">it will take the highest index of the array </param>
        public void DivideArray(int lowerIndex, int higherIndex)
        {
            if (lowerIndex < higherIndex)
            {
                ////finding middle element by adding lower 
                ////and highest and dividing by 2
                int middle = lowerIndex + ((higherIndex - lowerIndex) / 2);
                ////calling method recursively 
                ////first will divide till lower to middle
                this.DivideArray(lowerIndex, middle);
                ////this recusive method will divide from middle+1 to higherIndex
                this.DivideArray(middle + 1, higherIndex);
                ////this recursive method will 
                this.MergeArray(lowerIndex, middle, higherIndex);
            }
        }

        /// <summary>
        /// this method will take parameters 
        /// </summary>
        /// <param name="lowerIndex"> it will take lower index value</param>
        /// <param name="middle"> to get middle index</param>
        /// <param name="higherIndex"> to get the highest index of array</param>
        public void MergeArray(int lowerIndex, int middle, int higherIndex)
        {
            ////this for loop is used to check for each and every element in an array
            for (int m = lowerIndex; m <= higherIndex; m++)
            {
                this.tempMergeArray[m] = this.array[m];
            }

            int i = lowerIndex;
            int j = middle + 1;
            int k = lowerIndex;
            ////this loop is uesd to check whether the sub arraya are less than the middle and higer index
            while (i <= middle && j <= higherIndex)
            {
                if (string.Compare(this.tempMergeArray[i], this.tempMergeArray[j]) <= 0)
                {
                    this.array[k] = this.tempMergeArray[i];
                    i++;
                }
                else
                {
                    this.array[k] = this.tempMergeArray[j];
                    j++;
                }

                k++;
            }

            while (i <= middle)
            {
                this.array[k] = this.tempMergeArray[i];
                k++;
                i++;
            }
        }
    }
}
