using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernCoding;

namespace MatrixTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Matrix_Expected_MyException_i()
        {
            //act (���������)
            Matrix a = new Matrix(0, 2);
        }
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Matrix_Expected_MyException_j()
        {
            //act (���������)
            Matrix a = new Matrix(2, -1);
        }
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void this_Expected_MyException_set_j()
        {
            //act (���������)
            Matrix a = new Matrix(2, 2);
            a[1, 3] = 2;
        }
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void this_Expected_MyException_get_i()
        {
            //act (���������)
            Matrix a = new Matrix(2, 2);
            int r = a[3, 1];
        }
        [TestMethod]
        public void Equel()
        {
            //arrange(����������)
            Matrix a = new Matrix(2, 2);
            a[0, 0] = 1; a[0, 1] = 1; a[1, 0] = 1; a[1, 1] = 1;
            Matrix b = new Matrix(2, 2);
            b[0, 0] = 1; b[0, 1] = 1; b[1, 0] = 1; b[1, 1] = 1;
            //act (���������)
            //bool r = a == b;
            //assert(��������)
            //Assert.IsTrue(r);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void Summa()
        {
            //arrange(����������)
            Matrix a = new Matrix(2, 2);
            a[0, 0] = 1; a[0, 1] = 1; a[1, 0] = 1; a[1, 1] = 1;
            Matrix b = new Matrix(2, 2);
            b[0, 0] = 2; b[0, 1] = 2; b[1, 0] = 2; b[1, 1] = 2;
            Matrix expected = new Matrix(2, 2);
            expected[0, 0] = 3; expected[0, 1] = 3;
            expected[1, 0] = 3; expected[1, 1] = 3;
            Matrix actual = new Matrix(2, 2);
            //act (���������)
            actual = a + b;
            //assert(��������)
            Assert.IsTrue(actual == expected);//������
        }
        [TestMethod]
        public void Dif()
        {
            //arrange(����������)
            Matrix a = new Matrix(2, 2);
            a[0, 0] = 1; a[0, 1] = 1;
            a[1, 0] = 1; a[1, 1] = 1;
            Matrix b = new Matrix(2, 2);
            b[0, 0] = 2; b[0, 1] = 2; 
            b[1, 0] = 2; b[1, 1] = 2;
            Matrix expected = new Matrix(2, 2);
            expected[0, 0] = 1; expected[0, 1] = 1;
            expected[1, 0] = 1; expected[1, 1] = 1;
            Matrix actual = new Matrix(2, 2);
            //act (���������)
            actual = b - a;
            //assert(��������)
            Assert.IsTrue(actual == expected);//������
        }
        [TestMethod]
        public void Multiply()
        {
            //arrange(����������)
            Matrix a = new Matrix(2, 2);
            a[0, 0] = 1; a[0, 1] = 1; a[1, 0] = 1; a[1, 1] = 1;
            Matrix b = new Matrix(2, 2);
            b[0, 0] = 2; b[0, 1] = 2; b[1, 0] = 2; b[1, 1] = 2;
            Matrix expected = new Matrix(2, 2);
            expected[0, 0] = 4; expected[0, 1] = 4;
            expected[1, 0] = 4; expected[1, 1] = 4;
            Matrix actual = new Matrix(2, 2);
            //act (���������)
            actual = a * b;
            //assert(��������)
            Assert.IsTrue(actual == expected);//������
        }
        [TestMethod]
        public void transpose()
        {
            //arrange(����������)
            Matrix a = new Matrix(2, 2);
            a[0, 0] = 1; a[0, 1] = 2; a[1, 0] = 3; a[1, 1] = 4;
            
            Matrix expected = new Matrix(2, 2);
            expected[0, 0] = 1; expected[0, 1] = 3;
            expected[1, 0] = 2; expected[1, 1] = 4;
            Matrix actual = new Matrix(2, 2);
            //act (���������)
            actual = a.transp();
            //assert(��������)
            Assert.IsTrue(actual == expected);//������
        }

        [TestMethod]
        public void min()
        {
            //arrange(����������)
            Matrix a = new Matrix(2, 2);
            a[0, 0] = 1; a[0, 1] = 2; a[1, 0] = 3; a[1, 1] = 4;

            int expected = 1;

            //act (���������)
            int actual = a.min();
            //assert(��������)
            Assert.IsTrue(actual == expected);//������
        }
        [TestMethod]
        public void mtos()
        {
            //arrange(����������)
            Matrix a = new Matrix(2, 2);
            a[0, 0] = 1; a[0, 1] = 2; a[1, 0] = 3; a[1, 1] = 4;

            string expected = "1 2, 3 4";

            //act (���������)
            string actual = a.toString();
            //assert(��������)
            Assert.IsTrue(actual == expected);//������
        }

    }
}