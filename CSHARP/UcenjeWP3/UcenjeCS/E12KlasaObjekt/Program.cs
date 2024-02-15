using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E12KlasaObjekt.Edunova;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Program
    {
        public  static void Izvedi()
        {
            //objekt je instanca klase ili pojavnost nauciti napamet
            //osoba je klasa 
            //o je instanca klae (objekt , varijabla)

            Osoba osoba = new Osoba();
            osoba.Ime = "roki";   //Pomocno.UcitajString("unesi ime osobe");
            osoba.Prezime = "peric";

            Console.WriteLine(osoba.ImePrezime());

            osoba = new Osoba
            {
                Ime ="koko", //Pomocno.UcitajString("Unesi ime"),
                Prezime = "Kelić"
            
            };

            Osoba o = new()
            {

                Ime = "Ivana",
                Prezime = "jak"

            };

            var m = new Mjesto() { Naziv = "Osijek" };

            var direktor = new Osoba() { Prezime = "Kas" };
            direktor.Mjesto = m;
            Console.WriteLine(direktor.Mjesto?.Naziv);


            var s = new Smjer()
            {
                Naziv = "Web programiranje",
                Trajanje = 135,
                Cijena = 1234.55M,//M je jer je d zauzet za double 
                Sifra = 1,
                Vaucer = true
            };

            Predavac[] predavaci =
            {

                new() { Ime = "Šaki" , Prezime = "O'Neal"},
                new Predavac() {Ime = "Maja", Prezime = "Lak"}

            };
            Grupa g = new Grupa();
            g.Naziv = "Wp3"; //Grupa wp 3 je na smjeru web programiranje 
            g.Smjer = s;
            //Grupu wp3 vodi maja
            g.Predavac = predavaci[1];

            //ispisite 135 iz varijable g

            Console.WriteLine(g.Smjer.Trajanje);




        }
    }
}
