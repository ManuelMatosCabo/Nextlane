using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nextlane.Sections.Section2
{
    internal class Reverse
    {
        // Function to reverse a string (like a route) without predefined methods
        public static string ReverseString(string input)
        {
            // Convert the input string to a character array
            char[] charArray = input.ToCharArray();

            // Initialize two pointers: one at the beginning and one at the end
            int left = 0;
            int right = charArray.Length - 1;

            // Swap characters moving towards the center
            while (left < right)
            {
                // Temporary variable for swapping
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;

                // Move pointers towards each other
                left++;
                right--;
            }

            // Convert the character array back to a string and return
            return new string(charArray);
        }
    }
}
