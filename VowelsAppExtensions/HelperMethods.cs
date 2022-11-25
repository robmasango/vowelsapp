﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace VowelsAppExtensions
{
    public class HelperMethods
    {
        public List<char> Checkduplicates(string inputString)
        {
            inputString = RemoveWhitespace(inputString);
            var duplicates = new List<char>();
            foreach (var item in inputString)
            {
                if (inputString.IndexOf(item) != inputString.LastIndexOf(item) &&
                    !duplicates.Contains(item))
                {
                    duplicates.Add(item);
                }
            }

            return duplicates;
        }

        public Tuple<int, int> CountUniqueVowelsAndNonVowel(string inputString)
        {
            inputString = RemoveWhitespace(inputString);
            inputString = inputString.ToLower();
            inputString = new string(inputString.Distinct().ToArray());
            int i, len, vowel, nonvowel;

            vowel = 0;
            nonvowel = 0;
            len = inputString.Length;

            for (i = 0; i < len; i++)

                for (i = 0; i < len; i++)
                {
                    if (inputString[i] == 'a' || inputString[i] == 'e' || inputString[i] == 'i' || inputString[i] == 'o' || inputString[i] == 'u')
                    {
                        vowel++;
                    }
                    else
                    {
                        nonvowel++;
                    }
                }

            return new Tuple<int, int>(vowel, nonvowel); ;

        }

        public int GetUniqueVowels(string inputString)
        {
            int vowels = CountUniqueVowelsAndNonVowel(inputString).Item1;
            return vowels;
        }


        public string RemoveWhitespace(string input)
        {
            string inputString = new string(input.ToCharArray()
                .Where(c => !char.IsWhiteSpace(c))
                .ToArray());
            return inputString.ToLower();
        }
    }
}
