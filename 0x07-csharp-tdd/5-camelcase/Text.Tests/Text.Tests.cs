using NUnit.Framework;
using System;
using System.Linq;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [TestCase("thisStringHasMoreThenThreeWords", ExpectedResult=7)]
        [TestCase("this", ExpectedResult=1)]
        [TestCase("thisstringhasoneword", ExpectedResult=1)]
        [TestCase("", ExpectedResult=0)]
        [TestCase(null, ExpectedResult=0)]
        [TestCase("this String Has Five Words", ExpectedResult=5)]
        [TestCase("thishasOnecapitalletter", ExpectedResult=2)]
        [TestCase("OO", ExpectedResult=2)]
        public int TestRegular(string testStr)
        {
            int result = Text.Str.CamelCase(testStr);
            return (result);
        }
    }
}