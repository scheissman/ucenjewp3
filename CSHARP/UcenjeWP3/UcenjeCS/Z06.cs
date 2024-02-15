using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z06
    {
        public static void Izvedi()
        {
            //program ucitava dva cijela broja i ispisuje njihov zbroj

            int prvibroj = Pomocno.UcitajCijeliBroj("Unesi prvi broj", 0, int.MaxValue);
            int drugibroj = Pomocno.UcitajCijeliBroj("Unesi drugi broj");
            Console.WriteLine(prvibroj+drugibroj);


            Console.WriteLine(Pomocno.UcitajString("unesi ime grada"));
        }
    }
}
