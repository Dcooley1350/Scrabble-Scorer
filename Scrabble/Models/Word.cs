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
            TenPoint = new char[]{'q','z'};
        }
        public char[] ToCharArray()
        {
            return MasterWord.ToCharArray();
        }
        public void AwardOnePoint(char[] charArray)
        {
            foreach(char item in charArray)
            {
                foreach(char point in OnePoint)
                {
                    if(item == point)
                    {
                        WordScore++;
                    }
                }
            }
        }
        public void AwardPoints(char[] array)
        {
            AwardOnePoint(array);
            AwardTwoPoint(array);
            AwardThreePoint(array);
            AwardFourPoint(array);
            AwardFivePoint(array);
            AwardEightPoint(array);
            AwardTenPoint(array);
        }
       public void AwardTwoPoint(char[] charArray)
        {
            foreach(char item in charArray)
            {
                foreach(char point in TwoPoint)
                {
                    if(item == point)
                    {
                        WordScore +=2;
                    }
                }
            }
        }
       public void AwardThreePoint(char[] charArray)
        {
            foreach(char item in charArray)
            {
                foreach(char point in ThreePoint)
                {
                    if(item == point)
                    {
                        WordScore +=3;
                    }
                }
            }
        }
       public void AwardFourPoint(char[] charArray)
        {
            foreach(char item in charArray)
            {
                foreach(char point in FourPoint)
                {
                    if(item == point)
                    {
                        WordScore +=4;
                    }
                }
            }
        }
       public void AwardFivePoint(char[] charArray)
        {
            foreach(char item in charArray)
            {
                foreach(char point in FivePoint)
                {
                    if(item == point)
                    {
                        WordScore +=5;
                    }
                }
            }
        }
       public void AwardEightPoint(char[] charArray)
        {
            foreach(char item in charArray)
            {
                foreach(char point in EightPoint)
                {
                    if(item == point)
                    {
                        WordScore +=8;
                    }
                }
            }
        }
       public void AwardTenPoint(char[] charArray)
        {
            foreach(char item in charArray)
            {
                foreach(char point in TenPoint)
                {
                    if(item == point)
                    {
                        WordScore +=10;
                    }
                }
            }
        }

    }   


}