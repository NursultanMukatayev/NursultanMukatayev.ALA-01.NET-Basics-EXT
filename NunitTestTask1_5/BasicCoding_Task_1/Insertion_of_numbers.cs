// <copyright file="Insertion_of_numbers.cs" company="NMukatayev">
// Copyright (c) NMukatayev. All rights reserved.
// </copyright>

namespace Basic_Coding_NMukatayev_Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class to work with binary numbers.
    /// </summary>
    public class Insertion_of_numbers
    {
        /// <summary>
        /// Method to insert bits of one number into another.
        /// </summary>
        /// <param name="num_1">The number to insert bits in.</param>
        /// <param name="num_2">Bits of the number to be inserted.</param>
        /// <param name="i">Index of start position.</param>
        /// <param name="j">Index of end position.</param>
        /// <returns>A new number with inserted bits.</returns>
        public static int Insertion(int num_1, int num_2, int i, int j)
        {
            if (i < 0 || j < 0 || i > 31 || j > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(Insertion), "Indexes can't be lower than 0 or higher than 31");
            }

            if (i > j)
            {
                throw new ArgumentException("Starting index can't be higher than end index");
            }

            int shift_end = ((num_1 >> j) << (i + j)) | ((int.MaxValue >> (30 - i)) & num_1);
            int shift_strt = (num_2 << (i + 1)) & (int.MaxValue >> (30 - j));
            int end_num = shift_end | shift_strt;
            return end_num;
        }
    }
}
