using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProgramChallenges
{
    public class Palindrome
    {
        public static bool DetermineIfWorkdIsPalindrome(string word)
        {
            string trimmed = String.Concat(word.Where(c => !Char.IsWhiteSpace(c)));
            int endingIndex = trimmed.Length - 1;
            for (int i = 0; i < trimmed.Length; i++)
            {
                if (trimmed[i] != trimmed[endingIndex])
                {
                    return false;
                }
                endingIndex--;
            }
            return true;
        }
    }
}
