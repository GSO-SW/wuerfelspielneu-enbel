using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfelspiel
{
    class Becher:Wuerfel
    {
        private Wuerfel[] wuerfel = new Wuerfel[5];
        private int restlicheVersuche;

        public Becher(Wuerfel wuerfel)
        {
        }

        public Wuerfel[] Wuerfel
        {
            get
            {
                return wuerfel;
            }
        }
        public void WuerfelSicherungUmschalten()
        {
            SicherungUmschalten();
        }

        public void WuerfelWuerfeln()
        {
            Wuerfeln();
        }
    }
}
