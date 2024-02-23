using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Ljubavnikalkulator
    {
        public static void Izvedi()

        {
            string prvo, drugo, ukupno;
            prvo = UcitajString("Unesi prvo ime").ToLower();
            drugo = UcitajString("Unesi drugo ime").ToLower();
            ukupno = prvo + drugo;
            int[] brojevi = new int[2];
            char[] ukupnoarray = ukupno.ToCharArray();
            int[] brojevniarray = new int[ukupnoarray.Length];
            int pocetaknovogarraya = 0;

            foreach (char i in ukupnoarray)
            {
                int Zbroj = 0;
                foreach (char j in ukupnoarray)
                {
                    if (i == j)
                    {
                        Zbroj++;
                    }
                }
                brojevniarray[pocetaknovogarraya++] = Zbroj;
            }

            //ZbrojiRekurzivno(brojevniarray);

            string novoString = string.Join("", noviZbrojevi);

            int rezultat = int.Parse(novoString);

            Console.WriteLine(prvo + " + " + drugo + " se vole " + rezultat + "%");

        }

        static int[] ZbrojiRekurzivno(int[] brojevi)
        {
            int[] noviZbrojevi;

            if (brojevi.Length % 2 == 0)
            {
                noviZbrojevi = new int[brojevi.Length / 2];
            }
            else
            {
                noviZbrojevi = new int[brojevi.Length / 2 + 1];
            }

            for (int i = 0; i < brojevi.Length / 2; i++)
            {
                int zbroj = brojevi[i] + brojevi[brojevi.Length - 1 - i];
                if (zbroj >= 10)
                {
                    string zbrojString = zbroj.ToString();
                    noviZbrojevi[i] = int.Parse(zbrojString[0].ToString());
                    noviZbrojevi[noviZbrojevi.Length - 1] = int.Parse(zbrojString[1].ToString());
                }

                else
                {
                    noviZbrojevi[i] = zbroj;
                }
            }

            if (brojevi.Length % 2 != 0)
            {
                noviZbrojevi[noviZbrojevi.Length - 1] = brojevi[brojevi.Length / 2];
            }

            if (brojevi.Length > 3)
            {

                return ZbrojiRekurzivno(noviZbrojevi);
            }
            else
            {
                return noviZbrojevi;
            }
        }


        static string UcitajString(string poruka)
        {
            string s;
            while (true)
            {
                Console.Write(poruka + " : ");
                s = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(s))
                {
                    Console.WriteLine("Niste unijeli ništa.");
                    continue;
                }
                if (s.Any(char.IsDigit))
                {
                    Console.WriteLine("Unos ne smije sadržavati brojeve.");
                    continue;
                }
                return s;
            }
        }
    }
}
    

