using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]

  public class PalindromeCheckTests
  {
    [TestMethod]
    public void IsPalindrome_ChecksIfInputIsPalindrome_True()
    {
      PalindromeCheck testPalindromeCheck = new PalindromeCheck();
      Assert.AreEqual(true, testPalindromeCheck.IsPalindrome("racecar"));
    }

    [TestMethod]

    public void IsPalindrome_ChecksIfInputIsPalindrome_False()
    {
      PalindromeCheck testPalindromeCheck = new PalindromeCheck();
      Assert.AreEqual(false, testPalindromeCheck.IsPalindrome("booger"));
    }

    [TestMethod]

    public void IsPalindrome2_ChecksIfInputIsPalindrome_True()
    {
      PalindromeCheck testPalindromeCheck = new PalindromeCheck();
      Assert.AreEqual(true, testPalindromeCheck.IsPalindrome2("racecar"));
    }
  }
}