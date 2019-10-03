using System.Collections.Generic;
using System;
using System.Linq;

namespace Scrabble.Models
{
    public class Word
    {
        public string MasterWord { get; set; }
        public List<char> MasterList { get; set; }
        public int WordScore { get; set; }
        public Dictionary<int,char[]> LetterScores { get; set; }
        public char[] OnePoint { get; }
        public char[] TwoPoint { get; }
        public char[] ThreePoint { get; }
        public char[] FourPoint { get; }
        public char[] FivePoint { get; }
        public char[] EightPoint { get; }
        public char[] TenPoint { get;}


        public Word(string masterWord)
        {
            MasterWord = masterWord;
            MasterList = new List<char>();
            WordScore = 0;
            LetterScores = new Dictionary<int, char[]>();
            LetterScores.Add(1,new char[]{'a','e','i','o','u','l','n','r','s','t'});
            LetterScores.Add(2,new char[]{'d','g'});
            LetterScores.Add(3,new char[]{'b','c','m','p'});
            LetterScores.Add(4,new char[]{'f','h','v','w','y'});
            LetterScores.Add(5,new char[]{'k'});
            LetterScores.Add(8,new char[]{'j','x'});
            LetterScores.Add(10,new char[]{'q','z'});
        }
        public char[] ToCharArray()
        {
            return MasterWord.ToCharArray();
        }

        public void AwardPoints(char[] charArray)
        {
            foreach(char item in charArray)
            {
                foreach (KeyValuePair<int, char[]> entry in LetterScores)
                {
                    if( entry.Value.Contains(item))
                    {
                        WordScore += entry.Key;
                    }
                }
            }
        }

    }
}