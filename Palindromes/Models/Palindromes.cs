using System;
using System.Collections.Generic;

namespace Palindromes
{
  public class PalindromeCheck
  {
    public bool IsPalindrome(string input)
    {
      char[] splitInput = input.ToCharArray();
      Array.Reverse(splitInput);
      string reversedInput = string.Join("", splitInput);
      return input == reversedInput;
    }

    public bool IsPalindrome2(string input)
    {
      char[] splitInput = input.ToCharArray();
      List<char> reversedInput = new List<char>{};
      for (int i = splitInput.Length - 1; i >= 0; i--)
      {
        reversedInput.Add(splitInput[i]);
      }
      string strRevInput = string.Join("", reversedInput);
      return input == strRevInput;
    }
  }
}