using System;
using System.Collections.Generic;

namespace methods
{
    //this is a simple voting system progran
    internal static class Program
    {
        private static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Methods";
            Console.WriteLine("Enter the number of members to participate in the voting");
            var part = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            List<string> num;
            num = new List<string>();
            for (var voted = 0; voted < part; voted++)
            {
                Console.Write($"{voted} : ");
                num.Add(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}