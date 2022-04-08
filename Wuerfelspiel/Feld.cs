using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfelspiel
{
    class Feld:Block
    {
        private int akzeptierteAugenzahl;
        private int wert;

        public Feld(int akzeptierteAugenzahl)
        {
            this.akzeptierteAugenzahl = akzeptierteAugenzahl;
        }

        public int AkzeptierteAugenzahl
        {
            get
            {
                return akzeptierteAugenzahl;
            }
        }

        public int Wert
        {
            get
            {
                return wert;
            }
        }

        public int Eintragen(Wuerfel[])
        {
            
        }
    }
}
