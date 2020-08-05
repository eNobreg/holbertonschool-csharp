using NUnit.Framework;
using MyMath;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void testGeneral([Values(1, 3, 5, 7, 294, -100, 2000)] int a, [Values(-1000, -25452, -1, -24, -5, -100, 0)] int b, [Values(1000, 323, 542, 756, -294, -100, 22000)]int c)
        {
            List<int> list = new List<int> {99, 24, 67, 32, a, 37, b,  21, c, 0, 2};
            var max = list.Max();
            var funMax = MyMath.Operations.Max(list);
            Assert.AreEqual(max, funMax);
        }

        [Test]
        public void testReturn_Zero()
        {
            List<int> list = null;
            Assert.AreEqual(MyMath.Operations.Max(list), 0);
        }


        [Test]
        public void testReturnOnEmpty()
        {
            List<int> list = new List<int>();
            Assert.AreEqual(MyMath.Operations.Max(list), 0);
        }
    }
}