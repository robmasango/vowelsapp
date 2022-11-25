using System;
using System.Collections.Generic;
using System.Linq;

namespace VowelsAppExtensions
{
    public class RunApp
    {
        private readonly HelperMethods helpers = new HelperMethods();
        public int ExecuteApplication(string operations, string inputString)
        {
            int result = 0;
            if (operations.Contains("1") || operations.Contains("2") || operations.Contains("3"))
            {
                if (operations.Contains("1"))
                {
                    var record = helpers.Checkduplicates(inputString);

                    if (record.Count >= 1)
                    {
                        var finalString = new string(record.ToArray());
                        Console.WriteLine("Found the following duplicates: " + finalString);
                    }
                    else
                    {
                        Console.WriteLine("no duplicates found");
                    }

                    result = 1;
                }

                if (operations.Contains("2"))
                {
                    var vowels = helpers.GetUniqueVowels(inputString);
                    if (vowels >= 1)
                    {
                        Console.WriteLine("The number of vowels is: " + vowels.ToString());
                    }
                    else
                    {
                        Console.WriteLine("No vowels were found.");
                    }
                    result = 2;
                }
                if (operations.Contains("3"))
                {
                    int vowels = helpers.CountUniqueVowelsAndNonVowel(inputString).Item1;
                    int nonvowels = helpers.CountUniqueVowelsAndNonVowel(inputString).Item2;

                    if (vowels > nonvowels)
                    {
                        Console.WriteLine("The text has more vowels than non vowels.");
                    }
                    else if (vowels < nonvowels)
                    {
                        Console.WriteLine("The text has more non vowels than vowels.");
                    }
                    else if (vowels == nonvowels)
                    {
                        Console.WriteLine("The text has an equal amount of vowels and non vowels.");
                    }

                    result = 3;
                }
            }
            else
                result = -1;

            return result;
        }
    }
}
