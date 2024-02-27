using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class ljubavnikalk_v2
    {
        public static void Izvedi()
        {
            Console.WriteLine(@" /$$          /$$$$$ /$$   /$$ /$$$$$$$   /$$$$$$  /$$    /$$ /$$   /$$ /$$$$$$                    
| $$         |__  $$| $$  | $$| $$__  $$ /$$__  $$| $$   | $$| $$$ | $$|_  $$_/                    
| $$            | $$| $$  | $$| $$  \ $$| $$  \ $$| $$   | $$| $$$$| $$  | $$                      
| $$            | $$| $$  | $$| $$$$$$$ | $$$$$$$$|  $$ / $$/| $$ $$ $$  | $$                      
| $$       /$$  | $$| $$  | $$| $$__  $$| $$__  $$ \  $$ $$/ | $$  $$$$  | $$                      
| $$      | $$  | $$| $$  | $$| $$  \ $$| $$  | $$  \  $$$/  | $$\  $$$  | $$                      
| $$$$$$$$|  $$$$$$/|  $$$$$$/| $$$$$$$/| $$  | $$   \  $/   | $$ \  $$ /$$$$$$                    
|________/ \______/  \______/ |_______/ |__/  |__/    \_/    |__/  \__/|______/                    
                                                                                                   
                                                                                                   
                                                                                                   
 /$$   /$$  /$$$$$$  /$$       /$$   /$$ /$$   /$$ /$$        /$$$$$$  /$$$$$$$$ /$$$$$$  /$$$$$$$ 
| $$  /$$/ /$$__  $$| $$      | $$  /$$/| $$  | $$| $$       /$$__  $$|__  $$__//$$__  $$| $$__  $$
| $$ /$$/ | $$  \ $$| $$      | $$ /$$/ | $$  | $$| $$      | $$  \ $$   | $$  | $$  \ $$| $$  \ $$
| $$$$$/  | $$$$$$$$| $$      | $$$$$/  | $$  | $$| $$      | $$$$$$$$   | $$  | $$  | $$| $$$$$$$/
| $$  $$  | $$__  $$| $$      | $$  $$  | $$  | $$| $$      | $$__  $$   | $$  | $$  | $$| $$__  $$
| $$\  $$ | $$  | $$| $$      | $$\  $$ | $$  | $$| $$      | $$  | $$   | $$  | $$  | $$| $$  \ $$
| $$ \  $$| $$  | $$| $$$$$$$$| $$ \  $$|  $$$$$$/| $$$$$$$$| $$  | $$   | $$  |  $$$$$$/| $$  | $$
|__/  \__/|__/  |__/|________/|__/  \__/ \______/ |________/|__/  |__/   |__/   \______/ |__/  |__/");
            string ime1 = Pomocno.UcitajString(" Unesi prvo ime ").ToLower();
            string ime2 = Pomocno.UcitajString(" Unesi drugo ime ").ToLower();


            string ukupno = ime1 + ime2;
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
            string novoString = string.Join("", brojevniarray.Select(i => i.ToString()));
            



            int[] intArray = novoString.Select(c => int.Parse(c.ToString())).ToArray();
            Console.WriteLine(string.Join(",", intArray));

            int[] noviZbrojevi = ZbrojiRekurzivno(intArray);
            string novoString2 = string.Join("", noviZbrojevi);

            int rezultat = int.Parse(novoString2);

            Console.Write(ime1 + " i " + ime2 + " se vole " );
            
                if (rezultat <= 50)
                    { Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(rezultat + "%");
                Console.ResetColor(); }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(rezultat + "%");
                Console.ResetColor();


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
                    noviZbrojevi[i] = zbroj;
                }    

                

                if (brojevi.Length % 2 != 0)
                {
                    noviZbrojevi[noviZbrojevi.Length - 1] = brojevi[brojevi.Length / 2];
                }

                string pretvoreniustring = string.Join("", noviZbrojevi.Select(i => i.ToString()));
                int[] intNiz = pretvoreniustring.Select(c => int.Parse(c.ToString())).ToArray();







                if (intNiz.Length > 2)
                {
                    
                    Console.WriteLine(string.Join(",", intNiz));
                    return ZbrojiRekurzivno(intNiz);
                }
                else
                {
                    return noviZbrojevi;
                }
            }
        }
    }
}