using System;
using VowelsAppExtensions;

namespace VowelsApp
{
    class VowelsApp
    {
        private readonly static RunApp runApp = new RunApp();
        public static void Main()
        {

            Console.Write("\n\nVowels Application :\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("Enter text to be analysed : ");
            string str = Console.ReadLine();

            Console.Write("Enter which operations to do on the supplied text, ‘1’ for a duplicate character check, ‘2’ to count the number of vowels, ‘3’ to check if there are more vowels or non vowels, or any combination of ‘1’, ‘2’ and ‘3’ to perform multiple checks : ");
            string operations = Console.ReadLine();

            runApp.ExecuteApplication(operations, str);

            Console.Write("Exit");

        }



    }
}
