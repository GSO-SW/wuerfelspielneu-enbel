using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letzteErgebnis;
        private bool gesichert;
        private Random rnd;

        public Wuerfel ()
        {
        }
        public Wuerfel (int anzahlSeiten)
        {
        }

        public int AnzahlSeiten
        {
            get
            {
                return anzahlSeiten;
            }
        }

        public int LetztesErgebnis
        {
            get
            {
                return letzteErgebnis;
            }
        }

        public bool Gesichert
        {
            get
            {
                return gesichert;
            }
            set
            {
                this.Gesichert = gesichert;
            }
        }

        public void SicherungUmschalten ()
        {
            if (Gesichert == true)
            {
                Gesichert = false;
            }
            else
            {
                Gesichert = true;
            }
        }

        public int Wuerfeln()
        {
            letzteErgebnis = rnd.Next(1, 6);
            return letzteErgebnis;
        }
    }
}
