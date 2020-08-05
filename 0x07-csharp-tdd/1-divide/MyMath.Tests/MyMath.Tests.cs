using NUnit.Framework;
using System;
using System.Linq;
using MyMath;

namespace MyMath.Tests
{
	[TestFixture]
    public class Tests
    {        
        int[,] testMatrix;
        [SetUp]
        public void Setup()
        {
            this.testMatrix = new int[,]
            {
                {0, 1, 2, 99, 1000, -100},
                {3, 4, 5, 54, -621, 436},
                {6, 7, 8, -903, 100000, int.MaxValue}
            };
        }

        [Test]
        public void testDivision([Values(100, -100, 2, 53, 6, 1, 8, 1000)] int num)
        {
			int[,] newMatrix = new int[6,6];
			
			for(int i = 0; i < testMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < testMatrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = testMatrix[i, j] / num;
                }
            }

            var divided_matrix = MyMath.Matrix.Divide(testMatrix, num);
            bool isSame = true;
			
			for(int i = 0; i < testMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < testMatrix.GetLength(1); j++)
                {
                    if (testMatrix[i, j] != divided_matrix[i, j])
                    {
                        isSame = false;
                        break;
                    }
                }
            }
            Assert.That(isSame, Is.True);
        }

        [Test]
        public void testNull()
        {
            var result = MyMath.Matrix.Divide(null, 2);
            Assert.That(result == null);
        }

        [Test]
        public void testZero()
        {
            var result = MyMath.Matrix.Divide(testMatrix, 0);
            Assert.That(result == null);
        }
    }
}