using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibolovniDnevnik
{
    internal class Pomocno
    {
        public static int UcitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Nisi unio cijeli broj");
                }
            }
        }

        public static int UcitajCijeliBroj(string poruka, int min, int max)
        {
            int i;
            while (true)
            {
                i = UcitajCijeliBroj(poruka);
                if (i < min || i > max)
                {
                    Console.WriteLine("Učitani broj nije u danom rasponu " + min + " - " + max);
                    continue;
                }
                return i;
            }


        }

        public static float UcitajDecimalniBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Nisi unio cijeli broj");
                }
            }
        }

        // Napišite metodu koja prima string poruku i vraća
        // string koji ne smije biti prazan
        // metoda se zove UcitajString
        public static int UcitajBrojRaspon(string poruka, string greska,
            int poc, int kraj)
        {
            int b;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    b = int.Parse(Console.ReadLine());
                    if (b >= poc && b <= kraj)
                    {
                        return b;
                    }
                    Console.WriteLine(greska);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(greska);
                }
            }
        }
        internal static DateTime ucitajDatum(string v1, string v2)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(v1);
                    return DateTime.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(v2);
                }
            }
        }
                public static string UcitajString(string poruka)
        {
            string s;
            for (; ; )
            {
                Console.Write(poruka + ": ");
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }

                try
                {
                    int.Parse(s);
                    Console.WriteLine("Unos ne smije biti cijeli broj");
                    continue;
                }
                catch (Exception)
                {

                }

                try
                {
                    float.Parse(s);
                    Console.WriteLine("Unos ne smije biti decimalni broj");
                    continue;
                }
                catch (Exception)
                {

                }


                return s;
            }
        }
    }
}