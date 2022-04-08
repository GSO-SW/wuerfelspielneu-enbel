using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_KannErstelltWerden()
        {
            Wurfel w = new Wuerfel();
        }

        [TestMethod]
        public void Wuerfel_SeitenZahlRichtig()
        {
            int seitenzahl = 12;
            Wuerfel w = new Wuerfel(seitenzahl);
            Assert.AreEqual(seitenzahl, w.Seitenzahl);
            
        }
     

        [TestMethod]
        public void Wuerfel_wuerfeln()
        {
            //arrange 
            int anzahlseiten = 6;
            Wuerfel w = new Wuerfel();
           
            //act
            int ergebnis = w.Wuerfeln;
            //assert 
            Assert.IsNotNull( w.LetztesErgebnis);
        }
        [TestMethod]
        public void Wuerfel_GesichertFalse()
        {
            //arrange 
            Wuerfel w = new Wuerfel();
            bool gesichert = false;
            //act
            w.Sichern();
            //assert 
            Assert.AreEqual(gesichert, w.Gesichert);
        }
        [TestMethod]
        public void Wuerfel_GesichertTrue()
        {
            //arrange 
            Wuerfel w = new Wuerfel();
            bool gesichert = true;
            //act
            w.Sichern();
            //assert 
            Assert.AreEqual(gesichert, w.Gesichert);
        }
    }
    
}
