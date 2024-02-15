using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{   
    //klasa je opisnik objekta-Naucit napamet

    internal class Osoba
    {
        //klasa sadrzi svojstva
        public string? Ime { get; set; } //oop princip ucahurivanje
        public string?  Prezime { get; set; }
        //klasa sadrzi metode 



        public string ImePrezime() //ova metoda se moze pozvati na objektu , ne na klasi 
        {
            return Ime + " " + Prezime;
        }

        public Mjesto? Mjesto { get; set; }
        public static void Izvedi()// ovu metodu mogu pozvati na klasi a ne objektu
        {

        }

    }
}
