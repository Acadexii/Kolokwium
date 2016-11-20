using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Samochod :Pojazd
    {

        public Samochod() { }

        public Samochod(string marka , double srednieSpalanie):base(marka , srednieSpalanie){}        
           
        public string CzyDrogi()
        {
            double koszt = ObliczKosztPaliwa(150, 5);
            if (koszt >= 95)
                return "drogi";
            return "tani";

               

        }
    }
}
