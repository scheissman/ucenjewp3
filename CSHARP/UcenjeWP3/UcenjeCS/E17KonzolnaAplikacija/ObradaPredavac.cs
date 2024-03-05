using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E17KonzolnaAplikacija.Model;


namespace UcenjeCS.E17KonzolnaAplikacija
{
    internal class ObradaPredavac
    {
        public List<Predavac> Predavaci { get; }



        public ObradaPredavac()
        {
            Predavaci = new List<Predavac>();
            if (Pomocno.dev)
            {
                TestniPodaci();
            }

        }
            public void PrikaziIzbornik()
            {

                Console.WriteLine("Izbornik za rad s predavacima");
                Console.WriteLine("1. Pregled postojećih predavaca");
                Console.WriteLine("2. Unos novog predavaca");
                Console.WriteLine("3. Promjena postojećeg predavaca");
                Console.WriteLine("4. Brisanje predavaca");
                Console.WriteLine("5. Povratak na glavni izbornik");
                switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika polaznika: ",
                    "Odabir mora biti 1-5", 1, 5))
                {

                    case 1:
                        PregledPredavaca();
                        PrikaziIzbornik();
                        break;
                    case 2:
                        UcitajPredavaca();
                        PrikaziIzbornik();
                        break;
                    case 3:
                        PromjenaPredavaca();
                        PrikaziIzbornik();
                        break;
                    case 4:
                        BrisanjePredavaca();
                        PrikaziIzbornik();
                        break;
                    case 5:
                        Console.WriteLine("Gotov rad s predavacima");
                        break;


                }
            }

            private void PromjenaPredavaca()
            {
                PregledPredavaca();
                int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj predavaca: ", "Nije dobar odabir", 1, Predavaci.Count());
                var p = Predavaci[index - 1];
                p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifra predavaca (" + p.Sifra + "): ",
                    "Unos mora biti pozitivni cijeli broj");
                p.Ime = Pomocno.UcitajString("Unesi ime predavaca (" + p.Ime + "): ", "Ime obavezno");
                p.Prezime = Pomocno.UcitajString("Unesi Prezime predavaca (" + p.Prezime + "): ", "Prezime obavezno");
                p.Email = Pomocno.UcitajString("Unesi Email predavaca (" + p.Email + "): ", "Email obavezno");
                p.Oib = Pomocno.UcitajString("Unesi OIB predavaca (" + p.Oib + "): ", "OIB obavezno");
                p.Iban = Pomocno.UcitajString("Unesi Iban prdeavaca: ", "IBAN obavezbo");




            }

            private void BrisanjePredavaca()
            {
                PregledPredavaca();
                int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj predavaca: ", "Nije dobar odabir", 1, Predavaci.Count());
                Predavaci.RemoveAt(index - 1);
            }

            public void PregledPredavaca()
            {
                Console.WriteLine("------------------");
                Console.WriteLine("---- Predavaci ----");
                Console.WriteLine("------------------");
                int b = 1;
                foreach (Predavac predavac in Predavaci)
                {
                    Console.WriteLine("{0}. {1} {2} ", b++, predavac.Ime, predavac.Prezime);
                }
                Console.WriteLine("------------------");
            }

            private void UcitajPredavaca()
            {
                var p = new Predavac();
                p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifra predavaca: ",
                    "Unos mora biti pozitivni cijeli broj");
                p.Ime = Pomocno.UcitajString("Unesi ime predavaca: ", "Ime obavezno");
                p.Prezime = Pomocno.UcitajString("Unesi Prezime preadvaca: ", "Prezime obavezno");
                p.Email = Pomocno.UcitajString("Unesi Email predavaca: ", "Email obavezno");
                p.Oib = Pomocno.UcitajString("Unesi OIB predavaca: ", "OIB obavezno");
                p.Iban = Pomocno.UcitajString("Unesi Iban prdeavaca: ", "IBAN obavezbo");
                Predavaci.Add(p);

            }


            private void TestniPodaci()
            {




                Predavaci.Add(new Predavac
                {
                    Sifra = 1,
                    Ime = "Tomislav",
                    Prezime = "Jakopec",
                    Email = "tjakopec@nekimail.com",
                    Oib = "33736472822",
                    Iban = "12343344"
                });

                Predavaci.Add(new Predavac
                {
                    Sifra = 2,
                    Ime = "šeki",
                    Prezime = "O'Neal",
                    Email = "Šekijenajbolji@gmail.com",
                    Oib = "33736472821",
                    Iban = "Njemu ne trebaju pare , taj ima sve"
                });
            }

    }
}

