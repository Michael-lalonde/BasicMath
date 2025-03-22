using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMathTests
{
    [TestClass]
    public class BasicMathTests
    {
        private readonly BasicMath.BasicMath _basicMath = new BasicMath.BasicMath();

        [TestMethod]
        public void Test_AddMethod()
        {
            double result = _basicMath.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test_SubtractMethod()
        {
            double result = _basicMath.Subtract(5, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
            double result = _basicMath.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            double result = _basicMath.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(true); 
        }
    }
}