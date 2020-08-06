using NUnit.Framework;
using System.Collections.Generic;
using System;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void testRegularBehavior([Values("aafwwrrtthhdssdggttyy", "wwoorrdds", "ssllffssaarttyyuuii")] string s)
        {
            int index = 0;
            int i = 0;

            Dictionary<char, int> newDict = new Dictionary<char, int>(){};

            foreach (char c in s) 
            {
                if (!newDict.ContainsKey(c))
                {
                    newDict.Add(c, 1);
                }
                else
                {
                    newDict[c] += 1;
                }
            }

            foreach (char c in s)
            {
                if (newDict[c] == 1)
                {
                    index = i;
                }
                i += 1;
            }

            Assert.AreEqual(Text.Str.UniqueChar(s), index);
        }

        [Test]
        public void testAllUnique([Values("apple", "fail", "thing")] string s)
        {
            Assert.AreEqual(Text.Str.UniqueChar(s), 0);
        }

        [Test]
        public void testNoUnique([Values("fff", "ggg", "sssssddddd", null, "")] string s)
        {
            Assert.AreEqual(Text.Str.UniqueChar(s), -1);
        }
    }
}