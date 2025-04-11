using System;
using System.Collections.Generic;

namespace ConsoleApp7.Classes
{
    public static class WordToNumberConverter
    {
        private static readonly Dictionary<string, int> wordToNumberMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };

        public static int Convert(string word)
        {
            if (wordToNumberMap.TryGetValue(word, out int number))
            {
                return number;
            }
            throw new ArgumentException($"Невідоме слово: {word}");
        }

        public static bool IsValidWord(string word)
        {
            return wordToNumberMap.ContainsKey(word.ToLower());
        }
    }
}
