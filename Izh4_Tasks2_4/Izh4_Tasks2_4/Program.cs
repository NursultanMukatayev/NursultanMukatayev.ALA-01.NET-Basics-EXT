// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Izh4_Tasks2_4
{
using System;
using TasksLibrary;

public class Program
    {
        public static void Main()
        {
            UnsortedArrayTask an_array = new UnsortedArrayTask();
            foreach (int a in an_array.Arr)
            {
                Console.WriteLine(a + " ");
            }

            UnsortedArrayTask array2 = new UnsortedArrayTask(7);
            Console.Write("The max element of the array is: ");
            Console.WriteLine(Search_methods.Search_max(an_array.Arr, an_array.Arr.Length - 1));
            foreach (int a in array2.Arr)
            {
                Console.WriteLine(a + " ");
            }

            string abc = "ABCDDFAAAAFSDFDFDF";
            string cba = "AADDGGHFDGFDFDFd";
            string bca = StringConcat.DistinctConcatLinq(abc, cba);
            Console.WriteLine(bca);
            Console.WriteLine("The point of equilibrium is " + Search_methods.Equilibrium(array2.Arr));
            Console.ReadKey();
        }
    }
}
