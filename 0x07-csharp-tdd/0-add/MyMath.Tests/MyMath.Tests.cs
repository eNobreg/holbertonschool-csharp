using NUnit.Framework;
using System;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void testAdd([Values(-1, 2, 56, -89, 34, 78, int.MaxValue, int.MinValue)] int a, [Values(-9, 72, 506, 8998, -304, 38, int.MinValue, int.MaxValue)] int b)
        {
            Assert.AreEqual(MyMath.Operations.Add(a, b), a + b);
        }
    }
}