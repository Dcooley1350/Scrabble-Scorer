using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
    [TestClass]
    public class WordTest
    {
        Word newWord;
        char[] lowerArray;

        [TestInitialize]
        public void Setup()
        {
            newWord = new Word("Scrabble");
            char[] lowerArray = {'s','c','r','a','b','b','l','e'};
        }

        [TestCleanup]
        public void TearDown()
        {
            newWord = null;
            lowerArray = null;
        }


        [TestMethod]
        public void  WordConstructor_CreatesInstanceOfWord_Word()
        {
            Assert.AreEqual(newWord.GetType(),typeof(Word));
        }
        [TestMethod]
        public void ToLowerCase_ConvertsAllCapsToLowerCase_String()
        {
            string lowerMaster = newWord.MasterWord.ToLower();
            string lowerString = "scrabble";
            Assert.AreEqual(lowerMaster, lowerString);
        }
        [TestMethod]
        public void ToCharArray_ConvertStringToCharArray_CharArray()
        {   
            string lowerString = newWord.MasterWord.ToLower();
            char[] charArray = lowerString.ToCharArray();
            
            CollectionAssert.AreEqual(charArray,lowerArray);
        }
        [TestMethod]
        public void AwardOnePoint_IncrementScoreByOne_Int()
        {
            newWord.AwardOnePoint(lowerArray);

        }
    }
}