using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] n2 = new int[3] { 21, 13, 7 };

            var numQuery =
                from num in n2
                where (num % 2) != 0
                select num;

            Assert.AreEqual(41, numQuery.Sum());
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "1234";

            var numQuery =
                from str in s
                where str == '3'
                select str;

            Assert.AreEqual(1, numQuery.Count());
        }
    }
}
