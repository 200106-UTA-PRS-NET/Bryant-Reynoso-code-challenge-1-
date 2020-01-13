using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeLib
{
    public class Palindrome
    {
        public string ChangeToLower(string phrase)
        {
            return phrase.ToLower();
        }
        
        public string Reverse(string phrase)
        {
            string phraseReverse = "";

            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                phraseReverse += phrase[i];
            }

            return phraseReverse;
        }

        //trim off spaces and commas
        public string Trim(string trimPhrase)
        {

            trimPhrase = trimPhrase.Replace(" ", "").Replace(",", "").Replace(".", "");

            return trimPhrase;
        }

        public string CheckIfPalindrome(string phrase)
        {
            string phraseReverse = "";

            phrase = Trim(phrase);
            phraseReverse = Reverse(phrase);

            phrase = ChangeToLower(phrase);
            phraseReverse = ChangeToLower(phraseReverse);

            Console.WriteLine(phrase);
            Console.WriteLine(phraseReverse);

            if (phrase == phraseReverse)
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("is NOT a palindrome");
            }

           return phraseReverse;
        }
    }
}
