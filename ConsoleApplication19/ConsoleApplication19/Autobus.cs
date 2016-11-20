using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Autobus : Pojazd
    {
        private int iloscMiejsc;

        public Autobus() { }

        public Autobus(string marka , double srednieSpalanie, int iloscMiejsc):base(marka , srednieSpalanie)
        {
            this.iloscMiejsc = iloscMiejsc;
        }

        public double ObliczCeneZaBilet()
        {
            return ObliczKosztPaliwa(135, 5) * iloscMiejsc;
        }
    }
}
