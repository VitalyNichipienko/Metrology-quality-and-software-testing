using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] args = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double expectedResult = 384;

            var result = Unit_testing.TestClass.CalculateTheProductOfOddArrayElements(args);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void TestMethod2()
        {
            double[] args = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] expectedResult = new double[] { 8, 9, 1, 2, 3, 4, 5, 6, 7 };

            var result = Unit_testing.TestClass.ShiftArrayElements(args, 2);

            for (int i = 0; i < args.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }


        [TestMethod]
        public void TestMethod3()
        {
            int b = 8;
            string s = "0.45";

            int expectedResult = 45;

            var result = Unit_testing.TestClass.ConvertFractionalPartOfNumberToInteger(b, s);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
