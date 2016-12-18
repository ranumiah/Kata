using System.Collections.Generic;

namespace CountingDuplicates
{
    public class Kata
    {
        public static int DuplicateCount(string word)
        {
            Dictionary<char, int> duplicateCounter = new Dictionary<char, int>();
            int uniqueDuplicateLetters = 0;

            if (string.IsNullOrEmpty(word))
                return uniqueDuplicateLetters;
            
            foreach (char letter in GetLowerInvariantCharFor(word))
            {
                if (IsDuplicateLetter(duplicateCounter, letter))
                {
                    uniqueDuplicateLetters = UpdateDuplicateCounterForNewCharacter(duplicateCounter, letter, uniqueDuplicateLetters);
                    IncrementDuplicateCount(duplicateCounter, letter);
                }
                else
                {
                    duplicateCounter.Add(letter, 1);
                }
            }
            
            return uniqueDuplicateLetters;
        }

        private static string GetLowerInvariantCharFor(string word)
        {
            return word.ToLowerInvariant();
        }

        private static bool IsDuplicateLetter(Dictionary<char, int> duplicateCounter, char letter)
        {
            return duplicateCounter.ContainsKey(letter);
        }

        private static int UpdateDuplicateCounterForNewCharacter(Dictionary<char, int> duplicateCounter, char letter, int duplicateCount)
        {
            if (IsItNewDuplicateLetter(duplicateCounter, letter))
                duplicateCount++;
            return duplicateCount;
        }

        private static bool IsItNewDuplicateLetter(Dictionary<char, int> duplicateCounter, char letter)
        {
            return duplicateCounter[letter] == 1;
        }

        private static void IncrementDuplicateCount(Dictionary<char, int> duplicateCounter, char letter)
        {
            duplicateCounter[letter]++;
        }
    }
}
