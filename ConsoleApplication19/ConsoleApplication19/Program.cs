using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Samochod auto1 = new Samochod("Ford", 6.6);
            Samochod auto2 = new Samochod("Audi", 7.5);
            Autobus bus1 = new Autobus("mercedes", 12.0, 50);
            Autobus bus2 = new Autobus("Volvo", 10, 55);
            Console.WriteLine("Sebastian Wilkowski praca na 5!!!\n\n");
            


            Console.WriteLine("Cena za bilet Autobus1 : {0}",bus1.ObliczCeneZaBilet());
            Console.WriteLine("Cena za bilet Autobus2 : {0}",bus2.ObliczCeneZaBilet());
            Console.WriteLine(auto1.CzyDrogi());
            Console.WriteLine(auto2.CzyDrogi());


            Console.ReadKey();

        }
    }
}
