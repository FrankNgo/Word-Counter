using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class WordCount
  {
    private string _inputWord;
    private string _findWord;
    private int _count;

    public WordCount (string inputWord, string findWord)
    {
      _inputWord = inputWord;
      _findWord = findWord;
    }

    public string GetInputWord()
    {
      return _inputWord;
    }
    public string GetFindWord()
    {
      return _findWord;
    }

    public int RepeatCounter()
    {
      _count = 0;
      String[] newArray = _inputWord.Split(' ');
      string foundWord = _findWord.ToLower();
      foreach(string word in newArray)
      {
         string newWord = word.ToLower();
         if(newWord == foundWord)
         {
           _count = _count + 1;
         }
      }
      return _count;
    }
  }
}
