using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library1;


namespace MyClassTests
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void TestMethodArrangeNumbers1()
        {
            (int, int) args = (1, 0);
            (int, int) expectedResult = (0, 1);

            var result = TestClass.ArrangeNumbers(args.Item1, args.Item2);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void TestMethodArrangeNumbers2()
        {
            (int, int) args = (0, 0);
            (int, int) expectedResult = (0, 0);

            var result = TestClass.ArrangeNumbers(args.Item1, args.Item2);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void TestMethodSumEvenElementsOfMatrix1()
        {
            float[,] args = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };
            float expectedResult = 20;

            var result = TestClass.SumEvenElementsOfMatrix(args);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void TestMethodSumEvenElementsOfMatrix2()
        {
            float[,] args = { { 1, 1, 3 }, { 3, 5, 5 }, { 7, 7, 9 } };
            float expectedResult = 0;

            var result = TestClass.SumEvenElementsOfMatrix(args);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void TestMethodSumOddElementsOfTopMatrix1()
        {
            float[,] args = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            float expectedResult = 16;

            var result = TestClass.SumOddElementsOfTopMatrix(args);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void TestMethodSumOddElementsOfTopMatrix2()
        {
            float[,] args = { { 0, 0, 2 }, { 4, 4, 6 }, { 6, 8, 8 } };
            float expectedResult = 0;

            var result = TestClass.SumOddElementsOfTopMatrix(args);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
