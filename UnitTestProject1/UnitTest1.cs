using Microsoft.VisualStudio.TestTools.UnitTesting;
using stp8;
using System;

namespace stp8.Tests
{
    [TestClass]
    public class TProcTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            // Arrange & Act
            var proc = new Proc<int>();

            // Assert
            Assert.AreEqual(EOperation.None, proc.Operation);
            Assert.AreEqual(EFunction.None, proc.Function);
            Assert.AreEqual(0, proc.Lop_Res);
            Assert.AreEqual(0, proc.Rop);
        }

        [TestMethod]
        public void TestOperationClear()
        {
            // Arrange
            var proc = new Proc<int>();
            proc.OperationSet(1); // Set to Add

            // Act
            proc.OperationClear();

            // Assert
            Assert.AreEqual(EOperation.None, proc.Operation);
        }

        [TestMethod]
        public void TestOperationRun_Add()
        {
            // Arrange
            var proc = new Proc<int>(5, 3);
            proc.OperationSet(1); // Set to Add

            // Act
            proc.OperationRun();

            // Assert
            Assert.AreEqual(8, proc.Lop_Res);
        }

        [TestMethod]
        public void TestOperationRun_Sub()
        {
            // Arrange
            var proc = new Proc<int>(5, 3);
            proc.OperationSet(2); // Set to Sub

            // Act
            proc.OperationRun();

            // Assert
            Assert.AreEqual(2, proc.Lop_Res);
        }

        [TestMethod]
        public void TestOperationRun_Mul()
        {
            // Arrange
            var proc = new Proc<int>(5, 3);
            proc.OperationSet(3); // Set to Mul

            // Act
            proc.OperationRun();

            // Assert
            Assert.AreEqual(15, proc.Lop_Res);
        }

        [TestMethod]
        public void TestOperationRun_Div()
        {
            // Arrange
            var proc = new Proc<int>(6, 3);
            proc.OperationSet(4); // Set to Div

            // Act
            proc.OperationRun();

            // Assert
            Assert.AreEqual(2, proc.Lop_Res);
        }


        [TestMethod]
        public void TestFunctionClear()
        {
            // Arrange
            var proc = new Proc<int>();
            proc.FunctionSet(1); // Set to Rev

            // Act
            proc.FunctionClear();

            // Assert
            Assert.AreEqual(EFunction.None, proc.Function);
        }

        [TestMethod]
        public void TestFunctionRun_Rev()
        {
            // Arrange
            var proc = new Proc<double>(0, 2.0);
            proc.FunctionSet(1); // Set to Rev

            // Act
            proc.FunctionRun();

            // Assert
            Assert.AreEqual(0.5, proc.Rop);
        }

        [TestMethod]
        public void TestFunctionRun_Sqr()
        {
            // Arrange
            var proc = new Proc<int>(0, 3);
            proc.FunctionSet(2); // Set to Sqr

            // Act
            proc.FunctionRun();

            // Assert
            Assert.AreEqual(9, proc.Rop);
        }

        [TestMethod]
        public void TestLop_Res_Set()
        {
            // Arrange
            var proc = new Proc<int>();

            // Act
            proc.Lop_Res_Set(10);

            // Assert
            Assert.AreEqual(10, proc.Lop_Res);
        }

        [TestMethod]
        public void TestRop_Set()
        {
            // Arrange
            var proc = new Proc<int>();

            // Act
            proc.Rop_Set(5);

            // Assert
            Assert.AreEqual(5, proc.Rop);
        }

        [TestMethod]
        public void TestReSet()
        {
            // Arrange
            var proc = new Proc<int>(10, 5);

            // Act
            proc.ReSet();

            // Assert
            Assert.AreEqual(0, proc.Lop_Res);
            Assert.AreEqual(0, proc.Rop);
        }

        [TestMethod]
        public void TestRetLop_Res()
        {
            // Arrange
            var proc = new Proc<int>(10, 5);

            // Act
            string result = proc.RetLop_Res();

            // Assert
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void TestRetTLop_Res()
        {
            // Arrange
            var proc = new Proc<int>(10, 5);

            // Act
            int result = proc.RetTLop_Res();

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestRetRop()
        {
            // Arrange
            var proc = new Proc<int>(10, 5);

            // Act
            string result = proc.RetRop();

            // Assert
            Assert.AreEqual("5", result);
        }

        [TestMethod]
        public void TestRetTRop()
        {
            // Arrange
            var proc = new Proc<int>(10, 5);

            // Act
            int result = proc.RetTRop();

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestEquals()
        {
            // Arrange
            var proc1 = new Proc<int>(10, 5);
            var proc2 = new Proc<int>(10, 5);
            var proc3 = new Proc<int>(10, 6);

            // Act & Assert
            Assert.IsTrue(proc1.Equals(proc2));
            Assert.IsFalse(proc1.Equals(proc3));
        }
    }
}