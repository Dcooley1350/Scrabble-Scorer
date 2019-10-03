using System;
using Scrabble.Models;

namespace Scrabble
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Word:");
            string word = Console.ReadLine();
            string lowerWord = word.ToLower();
            Word newWord = new Word(lowerWord);
            char[] charArray = newWord.ToCharArray();
            newWord.AwardPoints(charArray);
            Console.WriteLine("That word is worth {0}",newWord.WordScore);

        }
    }
}