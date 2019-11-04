namespace TasksLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// A class that contains methods to work with arrays.
    /// </summary>
    public class Search_methods
    {
        /// <summary>
        /// A method to find a max element in an unsorted array.
        /// </summary>
        /// <param name="an_array">The array of a class.</param>
        /// <param name="size">Size on the array.</param>
        /// <returns>Max element.</returns>
        public static int Search_max(int[] an_array, int size)
        {
            int tmp;
            if (size == 1)
            {
                return an_array[0];
            }

            tmp = Search_max(an_array, size - 1);
            if (an_array[size] > tmp)
            {
                return an_array[size];
            }

            return tmp;
        }

        public static int Equilibrium(int[] an_array)
        {
            int leftsum = 0, rightsum = 0;
            for (int i = 1; i < an_array.Length; i++)
            {
                rightsum += an_array[i];
            }

            for (int i = 0; i < (an_array.Length - 1); i++)
            {
                if (leftsum == rightsum)
                {
                    return i;
                }

                leftsum += an_array[i];
                rightsum -= an_array[i + 1];
            }

            return -1;
        }
    }
}
