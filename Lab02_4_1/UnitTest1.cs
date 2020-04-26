using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab02_4_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = new int[5] { 2 , -9 , -11 ,74 ,55};
            int n = 5;
            int result1 = Lab02_4.Program.Max(a, n);
            Assert.AreEqual(74, result1);
            int result2 = Lab02_4.Program.Sum(a, n);
            Assert.AreEqual(-20, result2);
        }
    }
}
