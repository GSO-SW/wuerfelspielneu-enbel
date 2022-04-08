using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestClass]
        public class WuerfelTests
        {
            [TestMethod]
            public void Wuerfel_wuerfeln()
            {
                //arrange 
                Wuerfel w = new Wuerfel();
                int anzahlseiten = 6;
                //act
                int ergebnis = w.Wuerfeln(anzahlseiten);
                //assert 
                Assert.AreEqual(1 - 6, ergebnis);
            }
            [TestMethod]
            public void Wuerfel_LetztesErgebnisAbfagen()
            {
                //arrange 
                Wuerfel w = new Wuerfel();
                int anzahlseiten = 6;
                //act
                w.Wuerfeln(anzahlseiten);
                int ergebnis = w.LetztesErgebnis;
                //assert 
                Assert.AreEqual(1 - 6, ergebnis);
            }
        }
    }
}
