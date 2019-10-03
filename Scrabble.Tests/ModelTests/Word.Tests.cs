using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;

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
            lowerArray = new char[] {'s','c','r','a','b','b','l','e'};
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

            int correctScore = 5;
            Assert.AreEqual(newWord.WordScore, correctScore);
        }
        [TestMethod]
        public void AwardTwoPoint_IncrementScoreByTwo_Int()
        {
            newWord.AwardTwoPoint(lowerArray);
            int correctScore = 0;
            Assert.AreEqual(newWord.WordScore,correctScore);
        }
        [TestMethod]
        public void AwardThreePoint_IncrementScoreByThree_Int()
        {
            newWord.AwardThreePoint(lowerArray);
            int correctScore = 9;
            Assert.AreEqual(newWord.WordScore,correctScore);
        }
        [TestMethod]
        public void AwardFourPoint_IncrementScoreByFour_Int()
        {
            newWord.AwardFourPoint(lowerArray);
            int correctScore = 0;
            Assert.AreEqual(newWord.WordScore,correctScore);
        }
                [TestMethod]
        public void AwardFivePoint_IncrementScoreByFive_Int()
        {
            newWord.AwardFivePoint(lowerArray);
            int correctScore = 0;
            Assert.AreEqual(newWord.WordScore,correctScore);
        }
        [TestMethod]
        public void AwardEightPoint_IncrementScoreByEight_Int()
        {
            newWord.AwardEightPoint(lowerArray);
            int correctScore = 0;
            Assert.AreEqual(newWord.WordScore,correctScore);
        }
        [TestMethod]
        public void AwardTenPoint_IncrementScoreByTen_Int()
        {
            newWord.AwardTenPoint(lowerArray);
            int correctScore = 0;
            Assert.AreEqual(newWord.WordScore,correctScore);
        }
        [TestMethod]
        public void AwardPoints_IncrementByAllPointRules_Int()
        {
            newWord.AwardPoints(lowerArray);
            int correctScore = 14;
            Assert.AreEqual(newWord.WordScore,correctScore);
        }
    }
}