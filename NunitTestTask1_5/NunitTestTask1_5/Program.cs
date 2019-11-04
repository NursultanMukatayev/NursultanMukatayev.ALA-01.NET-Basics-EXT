// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NunitTestTask1_5
{
using System;
using Basic_coding_Task_6;
using TestingClass;

public class Program
    {
        public static void Main(string[] args)
        {
            InsertionAndFindNextBiggerNum f = new InsertionAndFindNextBiggerNum();
            f.Insertion_test_arg_out_of_range_exc_test(3, 1, 6, 5);
            FindNextBiggerNumTest ff = new FindNextBiggerNumTest();
            Console.WriteLine(ff.FindNextBiggerNumberNUnitTest1(25));
            int[] an_arr = { 0, 1, 333, 133, 12, 5, 7, 5, 12 };
            Digit digit = new Digit(1);
            int [] filtered= FilterDigitClass.FilterDigit(an_arr, digit);
            foreach (int i in filtered)
            {
                Console.WriteLine(i + " ");
            }

            Console.ReadKey();
        }
    }
}
