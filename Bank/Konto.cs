using System;

namespace Bank
{
    public class Konto
    {
        private double guthaben;
        private int kontoNr;
        private static int countKontoNr; //wird von allen Konto-Objekten geteilt

        public double Guthaben
        {
            get
            {
                return guthaben;
            }
        }


        public Konto(double guthaben)
        {
            countKontoNr++;
            this.kontoNr = countKontoNr;

            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Eröffnungsbetrag darf nicht negativ sein.");
            }

            this.guthaben = guthaben;
        }
        public int KontoNr { get { return kontoNr; } }

        public void Einzahlen(double betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(double betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }



    }
}

