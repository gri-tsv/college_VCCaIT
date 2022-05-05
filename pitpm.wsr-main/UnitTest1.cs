using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HandOver()
        {
            Myclass myClass = new Myclass();
            myClass.Rsch(10000000, 20080800, 33993, 4, 5, 6);
        }
        public void Equls()
        {
            Myclass myClass = new Myclass();
            int i = myClass.Rsch(1000, 220, 300, 9, 1, 6);

            Assert.AreEqual(i, 3135);
        }
        public void DevindedByZeero()
        {
            Myclass myClass = new Myclass();
            int i = myClass.Rsch(0, 0, 0, 1, 2, 3);
            Assert.AreEqual(i, -1);
        }
        public void NegativeNumb()
        {
            Myclass myClass = new Myclass();
            int i = myClass.Rsch(-1230, 10030, -320, -1, 2, 3);

            Assert.AreEqual(i, -1);
        }
        public void CharNum()
        {
            Myclass myClass = new Myclass();
            int i = myClass.Rsch(1230, 'o', 't', 1, 2, 3);
        }
        public void SoSmallNumb()
        {
            Myclass myClass = new Myclass();
            int i = myClass.Rsch(0.0001, 0.00012, 0.000032, 0.0000001, 0.00000003, 0.00000032);
        }
        public void TestEuls1()
        {
            Myclass myClass = new Myclass();
            int i = myClass.Rsch(1000, 220, 300, 9, 100, 6);

            Assert.AreEqual(i, 31350);
        }
        public void TestEuls2()
        {
            Myclass myClass = new Myclass();
            int i = myClass.Rsch(1000000, 2434220, 10, 9, 100, 6);

            Assert.AreEqual(i, 0);
        }
        public void TestEuls3()
        {
            Myclass myClass = new Myclass();
            int i = myClass.Rsch(1000000, 2434220, 0, 9, 100, 6);

            Assert.AreEqual(i, -1);
        }
        public void TestEuls4()
        {
            Myclass myClass = new Myclass();
            int i = myClass.Rsch(1000, 2420, 1.11, 9, 100, 6);

            Assert.AreEqual(i, 23456);
        }
    }
}
