using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfelspiel
{
    class Block
    {
        private List<Feld> felder = new List<Feld>();
        private int bonusGrenze;
        private int moeglicherBonus;
        private int zwischensumme;

        public Block()
        {

        }

        public Block(int bonusGrenze, int moeglicherBonus)
        {
            this.bonusGrenze = bonusGrenze;
            this.moeglicherBonus = moeglicherBonus;
        }

        public List<Feld> Felder
        {
            get
            {
                return felder;
            }
        }

        public int Zwischensumme
        {
            get
            {
                for (int i = 0; i < felder.Count; i++)
                { 
                    zwischensumme += Convert.ToInt32(felder[i]);
                }
                return zwischensumme;
            }
        }
        public int MoeglicherBonus
        {
            get
            {
                return moeglicherBonus;
            }
        }
        public int Summe
        {
            get
            {
                return zwischensumme + zwischensumme;
            }
        }

        //public void Eintragen(int feldNummer, Wuerfel[] wuerfel)
        //{
        //    wuerfel
        //}
    }
}
