using System.Text;

namespace Assignment_7_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 7.2.2
             * 
             * Given a string s, reverse only all the vowels in the string and return it.
             * The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
             */

            string s = "Hello, World!";

            Console.WriteLine(s);
            s = ReverseVowelsInString(s);
            Console.WriteLine($"Reversed vowels: {s}");

        }
        static string ReverseVowelsInString(string s_)
        {
            // HashSets make it easier to compare the chars with the Contains method
            HashSet<char> vowels = "aeiouAEIOU".ToHashSet();
            char[] chars = s_.ToCharArray();
            int left = 0; int right = s_.Length - 1;

            while (left < right)
            {
                if (!vowels.Contains(chars[left]))
                {
                    left++;
                    continue;
                }

                if (!vowels.Contains(chars[right]))
                {
                    right--;
                    continue;
                }

                // Swap vowels
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }

            return new string(chars);
        }
    }
}
