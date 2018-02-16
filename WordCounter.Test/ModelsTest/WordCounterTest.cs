using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void GetInputWord_GetsInput_ReturnString()
    {
      //Arrange
      WordCount newWordCount = new WordCount("My name is Frank","Frank");
      string testString = "My name is Frank";
      //Act
      string testInput = newWordCount.GetInputWord();
      //Assert
      Assert.AreEqual(testString, testInput);
    }
    [TestMethod]
    public void GetFindWord_GetsInput_ReturnString()
    {
      //Arrange
      WordCount newWordCount = new WordCount("My name is Frank","Frank");
      string testString = "Frank";
      //Act
      string testInput = newWordCount.GetFindWord();
      //Assert
      Assert.AreEqual(testString, testInput);
    }
  }
}
