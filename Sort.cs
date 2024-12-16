using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_7_1
{
    public class Sort
    {
        public static void SortGrades()
        {
            // Display the original array elements before sorting
            Console.Write("\nSorted Array Elements :\n\n");
            Swap.display_array_elements();

            int smallest;
            int[] data = { 60, 89,90,70,75,72};

            // Iterate through the array to perform selection sort
            for (int i = 0; i < data.Length - 1; i++)
            {
                smallest = i;

                // Find the index of the smallest element in the unsorted part of the array
                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    }
                }

                // Swap the current element with the smallest element found
                Swap.ReferenceEquals(i, smallest);

                // Display array elements after each swap (step-by-step)
                Swap.display_array_elements();
            }
        }

    }
}
