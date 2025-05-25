using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12_NIM;

namespace modul12_NIM.Tests
{
    [TestClass]
    public class UnitTestPangkat
    {
        Form1 form = new Form1();

        [TestMethod]
        public void TestBZero()
        {
            Assert.AreEqual(1, form.CariNilaiPangkat(0, 0));
        }

        [TestMethod]
        public void TestBNegative()
        {
            Assert.AreEqual(-1, form.CariNilaiPangkat(2, -3));
        }

        [TestMethod]
        public void TestBLebihDari10()
        {
            Assert.AreEqual(-2, form.CariNilaiPangkat(2, 11));
        }

        [TestMethod]
        public void TestALebihDari100()
        {
            Assert.AreEqual(-2, form.CariNilaiPangkat(101, 2));
        }

        [TestMethod]
        public void TestOverflow()
        {
            Assert.AreEqual(-3, form.CariNilaiPangkat(100, 10)); // kemungkinan overflow
        }

        [TestMethod]
        public void TestNormal()
        {
            Assert.AreEqual(8, form.CariNilaiPangkat(2, 3));
        }
    }
}
