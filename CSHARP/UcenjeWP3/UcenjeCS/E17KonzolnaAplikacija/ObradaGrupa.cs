using UcenjeCS.E17KonzolnaAplikacija.Model;

namespace UcenjeCS.E17KonzolnaAplikacija
{
    internal class ObradaGrupa
    {
        public List<Grupa> Grupe { get;  }

        private Izbornik Izbornik;

        public ObradaGrupa(Izbornik izbornik):this()
        {
            this.Izbornik = izbornik;
            if (Pomocno.dev)
            {
                TestniPodaci();
            }
        }

        public ObradaGrupa() 
        {
            Grupe = new List<Grupa>();
        }

        private void TestniPodaci()
        {
            Grupe.Add(new Grupa()
            {
                Sifra = 1,
                Naziv = "WP3",
                Smjer = Izbornik.ObradaSmjer.Smjerovi[0],
                Polaznici = Izbornik.ObradaPolaznik.Polaznici.GetRange(0, 5),
                
                DatumPocetka = DateTime.Now
            }) ;
        }

        public void PrikaziIzbornik()
        {
            
            Console.WriteLine("Izbornik za rad s grupama");
            Console.WriteLine("1. Pregled postojećih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena postojeće grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch(Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika grupa: ",
                "Odabir mora biti 1-5", 1, 5))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogGrupe();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjenaGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    BrisanjeGrupe();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s grupama");
                    break;
            }
        }

        private void PromjenaGrupe()
        {


            PrikaziGrupe();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj grupe: ", "Nije dobar odabir", 1, Grupe.Count());
            var p = Grupe[index - 1];
            int staraSifra = p.Sifra; 
            string stariNaziv = p.Naziv;
            Smjer stariSmjer = p.Smjer; 

            Console.WriteLine("Unesite novi šifra grupe ili pritisnite Enter za zadržavanje starog (" + p.Sifra + "): ");
            string novaSifraInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(novaSifraInput))
            {
                int novaSifra;
                if (int.TryParse(novaSifraInput, out novaSifra))
                {
                    p.Sifra = novaSifra;
                }
                else
                {
                    Console.WriteLine("Neispravan unos, zadržavam staru šifru.");
                }
            }

            Console.WriteLine("Unesite novi naziv grupe ili pritisnite Enter za zadržavanje starog (" + p.Naziv + "): ");
            string noviNazivInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(noviNazivInput))
            {
                p.Naziv = noviNazivInput;
            }

            Console.WriteLine("Trenutni smjer: {0}", p.Smjer.Naziv);
            Console.WriteLine("Unesite novi smjer grupe ili pritisnite Enter za zadržavanje starog (" + p.Smjer.Naziv + "): ");
            string noviSmjerInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(noviSmjerInput))
            {
                p.Smjer = PostaviSmjer();
            }
            else
            {
                p.Smjer = stariSmjer; 
            }


            Console.WriteLine("Trenutni polaznici:");
            Console.WriteLine("------------------");
            Console.WriteLine("---- Polaznici ----");
            Console.WriteLine("------------------");
            int b = 1;
            foreach (Polaznik polaznik in p.Polaznici)
            {
                Console.WriteLine("{0}. {1}", b++, polaznik);
            }
            Console.WriteLine("------------------");
            p.Polaznici = PostaviPolaznike();
            p.Predavaci = PostaviPredavace();

        }

        private Smjer PostaviSmjer()
        {
            Izbornik.ObradaSmjer.PrikaziSmjerove();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj smjera: ", "Nije dobar odabir", 1, Izbornik.ObradaSmjer.Smjerovi.Count());
            return Izbornik.ObradaSmjer.Smjerovi[index - 1];
        }

        private void BrisanjeGrupe()
        {
            PrikaziGrupe();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj grupe: ", "Nije dobar odabir", 1, Grupe.Count());
            Grupe.RemoveAt(index-1);
        }

        private void UnosNovogGrupe()
        {
            var g = new Grupa();
            int novaSifra;
            bool JedisnstvenaSifra = false;

            do
            {
                novaSifra = Pomocno.ucitajCijeliBroj("Unesite šifra grupe: ", "Unos mora biti pozitivni cijeli broj");
                JedisnstvenaSifra = jedinstvenasifra(novaSifra);

                if (!JedisnstvenaSifra)
                {
                    Console.WriteLine("Grupa sa unesenom šifrom već postoji. Molimo unesite jedinstvenu šifru.");
                }
            } while (!JedisnstvenaSifra);

            g.Sifra = novaSifra;
            g.Naziv = Pomocno.UcitajString("Unesite naziv grupe: ", "Unos obavezan");
            g.Smjer = PostaviSmjer();
            g.Polaznici = PostaviPolaznike();
            g.Predavaci = PostaviPredavace();
            g.DatumPocetka = Pomocno.ucitajDatum("Unesi datum grupe u formatu dd.MM.yyyy.", "Greška");

            Grupe.Add(g);
        }

        private bool jedinstvenasifra(int novaSifra)
        {
            foreach (var grupa in Grupe)
            {
                if (grupa.Sifra == novaSifra)
                {
                    return false;
                }
            }
            return true;
        }


        private List<Predavac> PostaviPredavace()
        {
            List<Predavac> predavaci = new List<Predavac>();
            while (Pomocno.ucitajBool("Želite li dodati predavaca (da ili bilo što drugo za ne): "))
            {
                predavaci.Add(PostaviPredavaca());
            }

            return predavaci;

        }

        private Predavac PostaviPredavaca()
        {
            Izbornik.ObradaPredavac.PregledPredavaca();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj predavaca: ", "Nije dobar odabir", 1, Izbornik.ObradaPredavac.Predavaci.Count());
            return Izbornik.ObradaPredavac.Predavaci[index - 1];
        }
        private void ObrisiPolaznika(List<Polaznik> polaznici)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("---- Polaznici ----");
            Console.WriteLine("------------------");

            int b = 1;
            foreach (Polaznik polaznik in polaznici)
            {
                Console.WriteLine("{0}. {1}", b++, polaznik);
            }
            Console.WriteLine("------------------");

            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj polaznika: ", "Nije dobar odabir", 1, polaznici.Count);

            polaznici.RemoveAt(index - 1);
            Console.WriteLine("Polaznik uspješno obrisan.");
        }



        private List<Polaznik> PostaviPolaznike()
        {
            List<Polaznik> polaznici = new List<Polaznik>();

            while (Pomocno.ucitajBool("Želite li dodati/brisati polaznike? (da ili bilo što drugo za ne): "))
            {
                int x = Pomocno.ucitajBrojRaspon("Za Unos novih polaznika (1) za brisanje (2)", "Nije dobar unos", 1, 2);
                if (x == 1)
                {
                    Polaznik noviPolaznik = PostaviPolaznika();
                    if (!polaznici.Contains(noviPolaznik))
                    {
                        polaznici.Add(noviPolaznik);
                    }
                    else
                    {
                        Console.WriteLine("Polaznik već postoji.");
                    }
                }
                else if (x == 2)
                {
                    ObrisiPolaznika(polaznici);
                }
            }
            return polaznici;
        }


        private Polaznik PostaviPolaznika()
        {
            Izbornik.ObradaPolaznik.PregledPolaznika();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj polaznika: ", "Nije dobar odabir", 1, Izbornik.ObradaPolaznik.Polaznici.Count());
            return Izbornik.ObradaPolaznik.Polaznici[index-1];
        }
        
        
       
    






    public void PrikaziGrupe()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("---- Grupe ----");
            Console.WriteLine("------------------");
            int b = 1;
            foreach(Grupa grupa in Grupe)
            {
                Console.WriteLine("{0}. {1} ({2})",b++,grupa.Naziv, grupa.Smjer.Naziv /* ovdje ispišite naziv smjera */ );
                foreach(Polaznik p in grupa.Polaznici)
                {
                    Console.WriteLine("\t" + p);
                }
            }
            Console.WriteLine("------------------");
        }

       
    }
}







