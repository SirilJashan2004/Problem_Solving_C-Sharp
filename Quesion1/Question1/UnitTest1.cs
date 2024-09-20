using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questionset1;
namespace Question1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1a()
        {
            Class1 Q1=new Class1();
            long Actual1 = Q1.Sum(int.MaxValue, 20);
            long Expected1 = 2147483667;                       
            Assert.AreEqual(Expected1, Actual1);
        }
        [TestMethod]
        public void TestMethod1b()
        {
            Class1 Q1 = new Class1();
            int Actual2 = Q1.Difference(10, 20);
            int Expected2 = 10;
            Assert.AreEqual(Expected2, Actual2);
        }
         [TestMethod]
        public void TestMethod1b1()
        {
            Class1 Q1 = new Class1();
            int Actual2 = Q1.Difference(10, 20);
            int Expected2 = -10;
            Assert.AreNotEqual(Expected2, Actual2);
        }       
        [TestMethod]
        public void TestMethod1c1()
        {
            Class1 Q1 = new Class1();
            int Actual2 = Q1.Product(10, 20);
            int Expected2 = 200;
            Assert.AreEqual(Expected2, Actual2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Class1 SI = new Class1();
            double Actual=SI.Simple(50000.0f, 3.5f, 3.0f);
            double Experted = 5250;
            Assert.AreEqual(Experted,Actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
           Class1 SI = new Class1();
           Assert.AreEqual(30, SI.GetLarge(10,30,23));

        }
        [TestMethod]
        public void TestMethod5()
        {
            Class1 ev = new Class1();
            Assert.AreEqual(true,ev.IsEven(4));
        }
        [TestMethod]
        public void TestMethod5a()
        {
            Class1 ev = new Class1();
            Assert.AreNotEqual(true, ev.IsEven(3));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Class1 vo = new Class1();
            Assert.AreEqual(true,vo.IsVowel('a'));
        }
         [TestMethod]
        public void TestMethod6a()
        {
            Class1 vo = new Class1();
            Assert.AreNotEqual(false, vo.IsVowel('a'));
        }
    }
}
