using System;
using PalindromeLib;

namespace PalindromeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Palindrome palindrome = new Palindrome();

            Console.Write("Enter a phrase: ");
            input = Console.ReadLine();

            palindrome.CheckIfPalindrome(input);
            
            Console.Read();
        }
    }
}
