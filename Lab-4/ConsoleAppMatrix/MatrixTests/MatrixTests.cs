using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppMatrix;


namespace MatrixTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]  
        public void Matrix_Expected_MyException_i()
        {
            Matrix a = new Matrix(0, 2);
        }


        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Matrix_Expected_MyException_j()
        {
            Matrix a = new Matrix(2, -1);
        }


        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void This_Expected_MyException_set_j()
        {
            Matrix a = new Matrix(2, 2);
            a[1, 3] = 2;
        }


        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void This_Expected_MyException_get_i()
        {
            Matrix a = new Matrix(2, 2);
            int r = a[3, 1];
        }


        [TestMethod]
        public void Equel()
        {
            Matrix a = new Matrix(2, 2);
            a[0, 0] = 1; 
            a[0, 1] = 1;
            a[1, 0] = 1;
            a[1, 1] = 1;
            Matrix b = new Matrix(2, 2);
            b[0, 0] = 1;
            b[0, 1] = 1;
            b[1, 0] = 1;
            b[1, 1] = 1;
            bool r = a == b;
            Assert.IsTrue(r);
        }


        [TestMethod]
        public void Summa()
        {
            Matrix a = new Matrix(2, 2);
            a[0, 0] = 1; 
            a[0, 1] = 1;
            a[1, 0] = 1; 
            a[1, 1] = 1;
            Matrix b = new Matrix(2, 2);
            b[0, 0] = 2;
            b[0, 1] = 2;
            b[1, 0] = 2;
            b[1, 1] = 2;
            Matrix expected = new Matrix(2, 2);
            expected[0, 0] = 3;
            expected[0, 1] = 3;
            expected[1, 0] = 3;
            expected[1, 1] = 3;
            Matrix actual = new Matrix(2, 2);
            actual = a + b;
            Assert.IsTrue(actual == expected);
        }
    }
}
