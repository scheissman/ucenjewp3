using RibolovniDnevnik;
using RibolovniDnevnik.Model;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;


internal class Program
{

    private List<Korisnik> Korisnici;
    private List<Unos> Unosi;
    private List<Ulov> Ulovi;
    private List<Ribe> Ribe;
    static void Main(string[] args)
    {
        new Program();
    }


    public Program()
    {
        Korisnici = new List<Korisnik>();
        Unosi = new List<Unos>();
        Ulovi = new List<Ulov>();
        Ribe = new List<Ribe>();



        Logo.logo();
        Odabir();

    }




    void Odabir()

    {
        Izbornici.PocetniIzbornik();

        switch (Pomocno.UcitajCijeliBroj("Unesi stavku izbornika: "))
        {
            case 1:
                Console.WriteLine("Rad s Korisnicima");
                RadsKorisnicima();
                break;
            case 2:
                Console.WriteLine("Rad s Unosima");
                RadsUnosima();
                break;
            case 3:
                Console.WriteLine("Rad s Ulovima");
                RadsUlovima();
                break;
            case 4:
                Console.WriteLine("Rad s ribama");
                RadsRibama();
                break;
            case 5:
                Console.WriteLine("ZAVRŠI APP");
                break;
            default:
                Console.WriteLine("Nisi dobro odabrao ");
                Odabir();
                break;
        }
    }

        void RadsKorisnicima()
        {
            Izbornici.IzbornikZaKorisnike();
            switch (Pomocno.UcitajCijeliBroj("Odaberi stavku "))
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Prikazi korisnike");
                    PrikazKorisnika();
                    RadsKorisnicima();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Dodaj Korisnika ");
                    NoviKorisnik();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Uredi Korisnika ");
                    UrediKorisnika();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Izbriši Korisnika ");
                    IzbrisiKorisnika();
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Vrati se na izbornik prije");
                    Odabir();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Krivi izbor");
                    RadsKorisnicima();
                    break;
            }
        }
        
    
    void PrikazKorisnika()
        {
        Console.WriteLine("*********************");
        Console.WriteLine("** Korisnici       **");
        Console.WriteLine("*********************");


        if (Korisnici.Count == 0)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Nema ni jednog korisnika  u sustavu");
            Console.WriteLine("*************************************");
            return;
        }

        int i = 1;

        foreach (var o in Korisnici)
        {
            Console.WriteLine(i++ + ". " + o);

        }
        Console.WriteLine("*********************");
         }
        
    
    
    void NoviKorisnik()
        {
        Console.WriteLine("******************************");

        Korisnici.Add(new Korisnik()
        {

            Ime = Pomocno.UcitajString("Unesi ime korisnika "),
            Prezime = Pomocno.UcitajString("Unesi prezime korisnika "),
            Email = Pomocno.UcitajString("Unesi email korisnika "),

        });
        Console.WriteLine();
        RadsKorisnicima();
         }
        
    
    void UrediKorisnika()
    {
        if (Korisnici.Count == 0)
        {
            Console.WriteLine("Nema korisnika za mijenjat");
            RadsKorisnicima();
        }
        PrikazKorisnika();
        int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj korisnika (0 odustani)", 0, Korisnici.Count);
        if (izbor == 0)
        {
            RadsKorisnicima(); 
        }
        var o = Korisnici[izbor - 1];
        o.Ime = Pomocno.UcitajString("Ucitaj ime [" + o.Ime + "]");
        o.Prezime = Pomocno.UcitajString("Ucitaj prezime");
        o.Email = Pomocno.UcitajString("Ucitaj Email");
        RadsKorisnicima();

    }

    void IzbrisiKorisnika()
    {
        if (Korisnici.Count == 0)
        {
            Console.WriteLine("Nema korisnika za brisati");
            RadsKorisnicima();
        }
        Console.WriteLine("**************************");
        Console.WriteLine("*** Brisanje korisnika ***");
        Console.WriteLine("**************************");
        PrikazKorisnika();
        int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj korisnika, (0 odustani)", 0, Korisnici.Count);
        if (izbor == 0)
        {
            RadsKorisnicima();
        }
        Korisnici.RemoveAt(izbor - 1);
        RadsKorisnicima();
    }
    Korisnik PostaviKorisnika()
    {
        PrikazKorisnika();
        int Index = Pomocno.UcitajBrojRaspon("Odaberi redni broj korisnika: ", "Nije dobar odabir", 1, Korisnici.Count());
        return Korisnici[Index - 1];
    }



    void RadsUnosima()


    {

        if (Korisnici.Count == 0)
        {
            Console.WriteLine("Morate prvo unjeti korisnika da biste mogli nastaviti sa unosima");
            Console.WriteLine("*******************************************************************");

            Odabir();
        }
        else
        {
            Izbornici.IzbornikZaUnos();
            switch (Pomocno.UcitajCijeliBroj("Odaberi stavku "))
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Prikazi Unose");
                    PrikazUnosa();
                    RadsUnosima();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Dodaj Unos ");
                    NoviUnos();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Uredi Unos ");
                    UrediUnos();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Izbriši Unos ");
                    IzbrisiUnos();
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Vrati se na izbornik prije");
                    Odabir();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Krivi izbor");
                    RadsUnosima();
                    break;
            }
        }


    }


    
    void PrikazUnosa()
    {
        if (Unosi.Count == 0)
        {
            Console.WriteLine("nema unosa , morate napraviti novi ");
            Console.WriteLine("************************************");

            RadsUnosima();

        }
        else
        {



            var i = 0;
            Unosi.ForEach(unos =>
            {
                Console.WriteLine(++i + ". " + unos);
            });
            if (Unosi.Count == 0)
            {
                Console.WriteLine("Nema unosa za prikaz");
            }
            Console.WriteLine("***************************");
        }
        
    }

    void NoviUnos()
    {
        Unosi.Add(new Unos()
        {

            Vodostaj = Pomocno.UcitajCijeliBroj("Unesi Vodostaj "),
            Biljeska = Pomocno.UcitajString("Unesi Biljesku "),
            Datum = DateTime.Now,
            Korisnik = PostaviKorisnika()



        });

        RadsUnosima();

    }
    void UrediUnos()
    {

        if (Unosi.Count == 0)
        {
            Console.WriteLine("Nema unosa za prikaz");
            Console.WriteLine("***************************");
        }

        else
        {
            int i = 1;

            foreach (var o in Unosi)
            {
                Console.WriteLine(i++ + ". " + o);

            }
            Console.WriteLine("*********************");

            var unos = Unosi[Pomocno.UcitajCijeliBroj("Odaberi unos za promjenu: ") - 1];
            unos.Vodostaj = Pomocno.UcitajCijeliBroj(unos.Vodostaj + ", Unesi novi vodostaj: ");
            unos.Biljeska = Pomocno.UcitajString(unos.Biljeska + ", Unesi novu biljesku  ");
            unos.Korisnik = PostaviKorisnika();
        }
        RadsUnosima();
    }


    void IzbrisiUnos()
    {
        if (Unosi.Count == 0)
        {
            Console.WriteLine("Nema Unosaa za brisati");
            RadsUnosima();
        }
        Console.WriteLine("**************************");
        Console.WriteLine("*** Brisanje Unosa     ***");
        Console.WriteLine("**************************");
        PrikazUnosa();
        int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj unosa, (0 odustani)", 0, Unosi.Count);
        if (izbor == 0)
        {
            RadsUnosima();
        }
        Unosi.RemoveAt(izbor - 1);
        RadsUnosima();
    }

















    void RadsUlovima()
    {
        if (Ribe.Count == 0 || Unosi.Count == 0)
        {
            Console.WriteLine("Morate prvo unjeti ribe i unos  da biste mogli nastaviti rad sa ulovima");
            Console.WriteLine("*******************************************************************");

            Odabir();
        }
        else
        {
            Izbornici.IzbornikZaUlove();
            switch (Pomocno.UcitajCijeliBroj("Odaberi stavku "))
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Prikazi Ulove");
                    PrikazUlova();
                    RadsUlovima();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Dodaj Ulov ");
                    NoviUlov();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Uredi Ulov ");
                    UrediUlov();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Izbriši Ulov ");
                    IzbrisiUlov();
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Vrati se na izbornik prije");
                    Odabir();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Krivi izbor");
                    RadsUlovima();
                    break;
            }
    }   }

    void PrikazUlova()
    {
        if (Ulovi.Count == 0)
        {
            Console.WriteLine("nema ulova , morate napraviti novi ");
            Console.WriteLine("************************************");

            RadsUlovima();

        }
        else
        {



            var i = 0;
            Ulovi.ForEach(ulovi =>
            {
                Console.WriteLine(++i + ". " + ulovi);
            });
            if (Unosi.Count == 0)
            {
                Console.WriteLine("Nema ulova za prikaz");
            }
            Console.WriteLine("***************************");
        }
    }

    void NoviUlov()
    {
        Ulovi.Add(new Ulov()
        {

            Kolicina = Pomocno.UcitajCijeliBroj("Unesi kolicinu ribe "),
            Tezina = Pomocno.UcitajString("Unesi Tezinu "),
            Duzina = Pomocno.UcitajString("UNesi duzinu "),

            Unos = PostaviUnos(),
            Ribe = PostaviRibe(),



        });

        RadsUlovima();

    }

    Unos PostaviUnos()
    {
        var i = 0;
        Unosi.ForEach(unos =>
        {
            Console.WriteLine(++i + ". " + unos);
        });
        if (Unosi.Count == 0)
        {
            Console.WriteLine("Nema unosa za prikaz");
        }
        Console.WriteLine("***************************");



        int Index = Pomocno.UcitajBrojRaspon("Odaberi redni brojunosa: ", "Nije dobar odabir", 1, Unosi.Count());
        return Unosi[Index - 1];
    }

    Ribe PostaviRibe()
    {
        var i = 0;
        Ribe.ForEach(ribe =>
        {
            Console.WriteLine(++i + ". " + ribe);
        });
        if (Ribe.Count == 0)
        {
            Console.WriteLine("Nema Riba za prikaz");
        }
        Console.WriteLine("***************************");

        
        int Index = Pomocno.UcitajBrojRaspon("Odaberi redni broj ribe: ", "Nije dobar odabir", 1, Ribe.Count());
        return Ribe[Index - 1];
    }



    void IzbrisiUlov()
    {
        if (Ulovi.Count == 0)
        {
            Console.WriteLine("Nema Ulova za brisati");
            RadsUlovima();
        }
        Console.WriteLine("**************************");
        Console.WriteLine("*** Brisanje Ulova    ***");
        Console.WriteLine("**************************");
        PrikazUlova();
        int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj unosa, (0 odustani)", 0, Ulovi.Count);
        if (izbor == 0)
        {
            RadsUlovima();
        }
        Ulovi.RemoveAt(izbor - 1);
        RadsUlovima();
    }

    void UrediUlov()
    {
        if (Ulovi.Count == 0)
        {
            Console.WriteLine("Nema ulova za prikaz");
            Console.WriteLine("***************************");
        }

        else
        {
            int i = 1;

            foreach (var o in Ulovi)
            {
                Console.WriteLine(i++ + ". " + o);

            }
            Console.WriteLine("*********************");

            var ulov = Ulovi[Pomocno.UcitajCijeliBroj("Odaberi ulov za promjenu: ") - 1];
            ulov.Tezina = Pomocno.UcitajString(ulov.Tezina + ", Unesi novu tezinu: ");
            ulov.Duzina = Pomocno.UcitajString(ulov.Duzina + ", Unesi novu Duzinu");
            ulov.Kolicina = Pomocno.UcitajCijeliBroj(ulov.Kolicina + ", Unesi novu kolicinu ");
            ulov.Ribe = PostaviRibe();
            ulov.Unos = PostaviUnos();
        }
        RadsUlovima();
    }




        

    

   

        void RadsRibama()
        {
                Izbornici.IzbornikZaRibe();
                switch (Pomocno.UcitajCijeliBroj("Odaberi stavku "))
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Prikazi Ribe");
                        PrikazRiba();
                        RadsRibama();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Dodaj Ribu ");
                        NovaRiba();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Uredi Ribe");
                        UrediRibe();
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Izbriši ribe ");
                        IzbrisiRibe();
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Vrati se na izbornik prije");
                        Odabir();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Krivi izbor");
                        RadsRibama();
                        break;
                }
        }

    void PrikazRiba()

    {
        Console.WriteLine("*********************");
        Console.WriteLine("**      Ribe       **");
        Console.WriteLine("*********************");


        if (Ribe.Count == 0)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Nema ni jedne ribe  u dnevniku   ***");
            Console.WriteLine("*************************************");
            RadsRibama();
        }

        int i = 1;

        foreach (var o in Ribe)
        {
            Console.WriteLine(i++ + ". " + o);

        }
        Console.WriteLine("*********************");
    }

    void NovaRiba()
    {
        Ribe.Add(new Ribe()
        {


            Vrsta = Pomocno.UcitajString("Unesi Vrstu ribe "),




        });

        RadsRibama();
    }

    

            
    
        void UrediRibe()
        {
                if (Ribe.Count == 0)
                {
                    Console.WriteLine("Nema riba za prikaz");
                    Console.WriteLine("***************************");
                    
                }
            PrikazRiba();

        int izbor = Pomocno.UcitajCijeliBroj("Izaberi unos ribe (0 odustani)", 0, Ribe.Count);
            if (izbor == 0)
            {
            RadsRibama();
             }
            var o = Ribe[izbor - 1];
            o.Vrsta = Pomocno.UcitajString("Ucitaj Vrstu [" + o.Vrsta + "]");
        
              RadsRibama();


    

        }
         
   
    void IzbrisiRibe()
    {
        if (Ribe.Count == 0)
        {
            Console.WriteLine("Nema Riba za brisati");
            RadsRibama();
        }
        Console.WriteLine("**************************");
        Console.WriteLine("*** Brisanje Riba      ***");
        Console.WriteLine("**************************");
        PrikazRiba();
        int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj unosa ribe", 0, Ribe.Count);
        if (izbor == 0)
        {
            RadsRibama();
        }
        Ribe.RemoveAt(izbor - 1);
        RadsRibama();
    }

}









