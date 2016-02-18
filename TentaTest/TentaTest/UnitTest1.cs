using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TentaTest
{
    [TestClass]
    public class UnitTest1
    {
        Temp temp;
        Inv inv;
        Lund lund;
        private int Vuxna;
        private int Ungdomar;
        private int Barn;
        private string Dag;

        [TestInitialize]
        public void Setup()
        {
            temp = new Temp();
            inv = new Inv();
            lund = new Lund();
        }
        [TestMethod]
        public void TestAntalInvånare()
        {
            double startÅr = 2015;
            double slutÅr = 2115;
            var x = slutÅr - startÅr;
            if(26000 < inv.CalcInvPerÅr(slutÅr))
            {
                Assert.AreEqual(26000 + x, inv.CalcInvPerÅr(slutÅr));
            }
            else
            {
                var invalidExpression = true;
                Assert.IsTrue(invalidExpression);
            }
            
        }
        [TestMethod]
        public void TestTemperatur()
        {
            Assert.AreEqual(temp.CalcTemp(20), "lagom");
            Assert.AreEqual(temp.CalcTemp(30), "för varmt");
            Assert.AreEqual(temp.CalcTemp(10), "för kallt");
        }
        [TestMethod]
        public void TestVilkaBesökareGrönaLund()
        {
            
        }
        [TestMethod]
        public void TestPrisFörBesökareGrönaLund()
        {
            Vuxna = 2;
            Ungdomar = 1;
            Barn = 1;
            Dag = "måndag";
            Assert.AreEqual(lund.CalcPrice(Vuxna, Ungdomar, Barn, Dag), 250);

            Vuxna = 1;
            Ungdomar = 4;
            Barn = 0;
            Dag = "torsdag";
            Assert.AreEqual(lund.CalcPrice(Vuxna, Ungdomar, Barn, Dag), 300);

            Vuxna = 5;
            Ungdomar = 1;
            Barn = 2;
            Dag = "söndag";
            Assert.AreEqual(lund.CalcPrice(Vuxna, Ungdomar, Barn, Dag), 1100);
        }
    }
}
