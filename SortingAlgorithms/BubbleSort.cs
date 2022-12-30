﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SortingAlgorithms
{
    public class BubbleSort
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Sort<T>(T[] array) where T:IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j].CompareTo(array[j+1])>0)
                    {
                        Sorting.Swap<T>(array, j, j + 1);
                    }
                }
            }
        }
    }
}
