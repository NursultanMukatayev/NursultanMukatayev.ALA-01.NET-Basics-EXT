// <copyright file="Digit.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Basic_coding_Task_6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class which will store the specified digit.
    /// </summary>
    public class Digit
    {
        private int digit;

        /// <summary>
        /// Initializes a new instance of the <see cref="Digit"/> class with a set digit.
        /// </summary>
        /// <param name="digit">The value.</param>
        public Digit(int digit)
        {
            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "The value should be between 0 and 9");
            }

            this.digit = digit;
        }

        public bool ContainsDigit(int thenum)
        {
            if (thenum < 0)
            {
                thenum *= -1;
            }

            while (thenum > 0)
            {
                if (thenum % 10 == this.digit)
                {
                    return true;
                }

                thenum /= 10;
            }

            return false;
        }
    }
}
