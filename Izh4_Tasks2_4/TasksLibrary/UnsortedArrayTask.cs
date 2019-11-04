// <copyright file="UnsortedArrayTask.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace TasksLibrary
{
    using System;

    /// <summary>
    /// Class with method to find the max element on an array.
    /// </summary>
    public class UnsortedArrayTask
    {
        private int[] arr;

        public int[] Arr
        {
            get
            {
                return this.arr;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnsortedArrayTask"/> class with a randomly filled array.
        /// </summary>
        public UnsortedArrayTask()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            this.arr = new int[rnd.Next(3, 10)];
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] = rnd.Next(0, 101);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnsortedArrayTask"/> class with a given size and mirrored left and right sides.
        /// </summary>
        /// <param name="size">The size of the array.</param>
        public UnsortedArrayTask(int size)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            this.arr = new int[size];
            int helper = 0;
            for (int i = 0; i < size / 2; i++)
            {
                this.arr[i] = rnd.Next(-50, 50);
                helper++;
            }

            helper -= 1;
            for (int j = (size / 2) + 1; j < size; j++)
            {
                this.arr[j] = this.arr[helper--];
            }

            this.arr[size / 2] = rnd.Next(-100, 100);
        }
    }
}