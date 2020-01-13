using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeLib;

namespace PalindromeTest
{
    [TestClass]
    public class TestPalindrome
    {
        Palindrome palindrome = new Palindrome();

        [TestMethod]
        public void TestInstanceType()
        {
            string actual = palindrome.ChangeToLower("nurses run");
            Assert.IsInstanceOfType(actual,typeof(string));
        }
         

        [TestMethod]
        public void TestReverse()
        {
            string expectedReverse = "nursesrun";

            string actualReverse = palindrome.Reverse(expectedReverse);

            Assert.AreEqual(expectedReverse, actualReverse);
        }

        public void TestTrim()
        {
            string expectedTrim = "neveroddoreven";

            string actualTrim = palindrome.Trim("never odd, or even.");

            Assert.AreEqual(expectedTrim, actualTrim);
        }

        [TestMethod]
        public void TestCheckIfPalindrome()
        {
            
            //Arrange
            string expectedPalindrome = "neveroddoreven";
            

            //Act
            string actualPalindrome = palindrome.CheckIfPalindrome("never odd, or EVEN.");

            //Assert
            Assert.AreEqual(expectedPalindrome, actualPalindrome);
            
        }
    }
}
