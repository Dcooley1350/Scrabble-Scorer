namespace Scrabble.Methods
{
    public class Word
    {
        public string MasterWord { get; set; }
        public List<char> MasterList { get; set }
        public int WordScore { get; set; }


        public Word(string masterWord)
        {
            MasterWord = masterWord;
            MasterList = new List<char>();
            WordScore = 0;

        }
    }
}