using Microsoft.VisualStudio.TestTools.UnitTesting;
using library_for_test;
namespace fsfsdfsdfds
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int input = 10;
            int[] output = new int [3]{ 1, 2, 5 };
            int[] got = library_for_test1.PrimeFactors(input);
            Assert.Equals(output, got);
        }
        public void TestMethod2()
        {
            int input = 5;
            int[] output = new int[2] { 1,5 };
            int[] got = library_for_test1.PrimeFactors(input);
            Assert.Equals(output, got);
        }

    }
}
