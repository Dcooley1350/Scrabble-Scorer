using System.Collections.Generic;

namespace Scrabble.Models
{
    public class Word
    {
        public string MasterWord { get; set; }
        public List<char> MasterList { get; set; }
        public int WordScore { get; set; }
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
            OnePoint = new char[] {'a','e','i','o','u','l','n','r','s','t'};
            TwoPoint = new char[]{'d','g'};
            ThreePoint = new char[] {'b','c','m','p'};
            FourPoint = new char[] {'f','h','v','w','y'};
            FivePoint = new char[] {'k'};
            EightPoint = new char[] {'j','x'};
            TenPoint = new char[]{'q','b'};
        }
        public char[] ToCharArray()
        {
            return MasterWord.ToCharArray();
        }
        public void AwardOnePoint(char[] charArray)
        {
            foreach(char item in charArray)
            {

            }
        }
    }   


}