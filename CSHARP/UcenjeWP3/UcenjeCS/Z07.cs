using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z07
    {
        public static void Izvedi() 
        {
            // Pogram unosi ime osobe, visinu i težinu
            // Program ispisuje crvenom bojom
            // ako je visina > 170 i < 190 te težina je < 90,5
            // Ti, XXXX si zgodan / zgodna

            string ime = Pomocno.UcitajString("Kako se zoves");
            int visina = Pomocno.UcitajCijeliBroj("Koliko si visok?");
            float tezina = Pomocno.UcitajDecimalniBroj("Koliko imas kg?");
            if (visina > 170 && visina <190 && tezina < 90.5) 
            {
            Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ime[^1] == 'a' ? $"Ti {ime} si zgodna " : $"Ti {ime} si zgodan ");
                Console.ResetColor();
            }













        }
    }
}
