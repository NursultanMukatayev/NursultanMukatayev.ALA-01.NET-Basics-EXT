// <copyright file="FindNextBiggerNumber.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Basic_coding_Task_5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class with a method to find the biggest number which can be made with digits of a given number.S
    /// </summary>
    public class FindNextBiggerNumber
    {
        private static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        private static bool HasNoBiggerNumber(int[] composednum)
        {
            int a = 0;
            for (int i = 0; i < composednum.Length - 1; i++)
            {
                if (composednum[i] >= composednum[i + 1])
                {
                    a++;
                }
            }

            if (a == composednum.Length - 1)
            {
                return true;
            }

            return false;
        }

        public static int FindNextBiggerNumber_(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)} must be positive.");
            }

            int[] numberArray = new int[number.ToString().Length];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(number.ToString()[i].ToString());
            }

            if (HasNoBiggerNumber(numberArray))
            {
                return -1;
            }

            for (int i = numberArray.Length - 1; i >= 0; i--)
            {
                if (numberArray[i] > numberArray[i - 1])
                {
                    Swap(ref numberArray[i], ref numberArray[i - 1]);
                    break;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (int i in numberArray)
            {
                stringBuilder.Append(i);
            }

            return int.Parse(stringBuilder.ToString());
        }
    }
}
