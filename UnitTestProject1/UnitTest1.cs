using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Lab4.MathCalc;
using static Lab4.Program;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EnterNumber_1_equal_0()
        {
            double expected = 0, actual;
            actual = GetAnswerXBiggerZero(1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EnterNumber_0_equal_4()
        {
            double expected = 4, actual;
            actual = GetAnswerXLowerOrEqualZero(0);
            Assert.AreEqual(expected, actual);
        }
    }
}
