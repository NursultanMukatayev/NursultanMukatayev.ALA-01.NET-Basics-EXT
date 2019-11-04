// <copyright file="FilterDigitClass.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Basic_coding_Task_6
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class that contains the method to filter an array.
    /// </summary>
    public class FilterDigitClass
    {
        public static int[] FilterDigit(int[] an_array, Digit a_digit)
        {
            if (an_array is null || a_digit is null)
            {
                throw new ArgumentNullException();
            }

            List<int> temp = new List<int>();
            for (int i = 0; i < an_array.Length; i++)
            {
                if (a_digit.ContainsDigit(an_array[i]))
                {
                    temp.Add(an_array[i]);
                }
            }

            return temp.ToArray();
        }
    }
}
