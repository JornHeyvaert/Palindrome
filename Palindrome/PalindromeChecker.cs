using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class PalindromeChecker
    {
        public static bool isWordAPalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        public static bool isSentenceAPalindrome(string sentence)
        {
            int min = 0;
            int max = sentence.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = sentence[min];
                char b = sentence[max];

                // Scan forward for a while invalid.
                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = sentence[min];
                }

                // Scan backward for b while invalid.
                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = sentence[max];
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
