using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_7_1
{
    public class Swap
    {

        // Method to swap two elements in the array
        public static void SwapGrades(int first, int second)
        {
            int[] data = { 60, 89, 90, 70, 75, 72 };
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }

        // Method to display array elements
        public static void display_array_elements()
        {
            int[] data = { 60, 89, 90, 70, 75, 72 };
            // Display each element of the array
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }
    }
}
