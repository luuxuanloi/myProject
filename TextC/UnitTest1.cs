using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using github;


namespace testmaytinh
{
    [TestClass]
    public class UnitTest1
    {
        private int a, b, c, d;

        [TestInitialize]

        public void init()
        {
            this.a = 5;
            this.b = 10;
            this.c = -6;
            this.d = -11;
        }

        public void TestMethod1()
        {

        }


        [TestMethod]
        public void testconghaisoduong()
        {
            Calculation cal = new Calculation(this.a, this.b);
            int expected = 15;
            int actual = cal.execute("+");
            Assert.AreEqual(expected, actual);
        }


        public void testconghaisoam()
        {
            Calculation cal = new Calculation(this.c, this.d);
            int expected = -17;
            int actual = cal.execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}
