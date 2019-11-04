// <copyright file="StringConcat.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TasksLibrary
{
    using System.Linq;
    using System.Text.RegularExpressions;
    /// <summary>
    /// A class that contains the method to concat 2 strings.
    /// </summary>
    public class StringConcat
    {
        /// <summary>
        /// Initializes static members of the <see cref="StringConcat"/> class.
        /// Method to concat 2 strings with only latin letters via LinQ.
        /// </summary>
        /// <param name="str1">First string to concat.</param>
        /// <param name="str2">Second string to concat.</param>
        public static string DistinctConcatLinq(string str1, string str2)
        {
            if (!Regex.IsMatch(str1, @"^[a-zA-Z0-9]+$") || !Regex.IsMatch(str2, @"^[a-zA-Z0-9]+$"))
            {
                throw new System.Exception("The strings are not in the right format");
            }

            string concatstr = str1 + str2;
            concatstr = new string(concatstr.Distinct().ToArray());
            return concatstr;
        }
    }
}
