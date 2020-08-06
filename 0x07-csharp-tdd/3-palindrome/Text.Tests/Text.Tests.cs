using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void testTrue([Values("this is a palindromemordnilap a si siht", "adsfggsaaasggfsda", "ad sfggs,,aaasggfs,da", "")] string str)
        {
            Assert.That(Text.Str.IsPalindrome(str), Is.True);
        }
        
        [Test]
        public void testFalse([Values("this i a palindromemordnilap a si siht", "adsfggsasgfsda", "ad fggs,,aaasgfs,da")] string str)
        {
            Assert.That(Text.Str.IsPalindrome(str), Is.False);
        }
    }
}