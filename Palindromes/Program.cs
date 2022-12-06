using System;
using System.Collections.Generic;
using Palindromes;

public class Program 
{
  public static void Main()
  {
    PalindromeCheck palindromeCheck = new PalindromeCheck();
    Console.WriteLine("Enter a word or number to see if it is a palindrome:");
    string userInput = Console.ReadLine();
    if (palindromeCheck.IsPalindrome(userInput))
    {
      Console.WriteLine("Your word is a palindrome!");
    }
    else
    {
      Console.WriteLine("Your word is NOT a palindrome!");
    }
  }
}