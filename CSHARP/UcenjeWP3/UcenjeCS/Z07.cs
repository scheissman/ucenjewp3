using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mojeucenjecs
{
    public class Z07
    {
        public static void Izvedi()
        {
            //program unosi ime osoobe , visinu i tezinu 
            //program ispisuje crvenom bojom 
            //ako je visina > 170 i < 190 , te tezina < 90.5kg
            //ti , ime si zgodan ili zgodna

            string ime = Pomocno.UcitajString("Unesi ime osobe");
            int visina = Pomocno.UcitajCijeliBroj("Unesi visinu u cm ");
            float tezina = Pomocno.UcitajDecimalniBroj("Unesi tezinu ");

            if (visina > 170 && visina < 190 && tezina < 90.5)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine(ime[^1] == 'a' ? "zgodna si " + ime : "zgodan si " + ime);
            Console.ResetColor(); 
            }
            else
            {
                System.Console.WriteLine("ocigledno nisi dobroizgledajuci ");
            }



        }
    }
}