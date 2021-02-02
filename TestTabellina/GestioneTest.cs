using Microsoft.VisualStudio.TestTools.UnitTesting;
using libreriaTAbellina;
namespace TestTabellina
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void Max()
        {
            int a = 500;
            int b = 402;
            int valoreAspetatto = 500;
            int resp = MaxMin.Massimo(a, b);
            Assert.AreEqual(valoreAspetatto, resp);
        }
        [TestMethod]
        public void Min()
        {
            int a = 500;
            int b = 402;
            int valoreAspetatto = 402;
            int resp = MaxMin.Minimo(a, b);
            Assert.AreEqual(valoreAspetatto, resp);
        }
    }
}
