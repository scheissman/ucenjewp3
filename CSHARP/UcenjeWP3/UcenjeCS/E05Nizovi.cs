using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {
            //eng arrays a na hr nizovi, polja i ostala zezancija

            int[] Temperature = new int[12];
            Temperature[0] = 1; //index za prvo mjesto
            Temperature[Temperature.Length - 1] = 2; // Zadnje mjesto 

            Console.WriteLine(Temperature);

            //foreach (int i in Temperature)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine(string.Join(",",Temperature)); //ispisi niz

            string[] gradovi = new string[3];
            gradovi[0] = "Osijek";
            gradovi[1] = "Zagreb";
            gradovi[2] = "Donji Miholjac";

            Console.WriteLine(string.Join(" ",gradovi)); //ispise se sa razmakom , moze se ubacit sta hoce

            int[] brojevi = { 2, 3, 3, 4, 7, 5, 5, 44, 33, 22, 65 };

            //ispisi broj 7 
            Console.WriteLine(brojevi[4]);

            Console.WriteLine(brojevi[0]); // prvi element

            Console.WriteLine(brojevi[brojevi.Length-1]); //zadnji element

            // ovoo su jednodimenzionalni nizovi 

            //sad cemo krkat 2d :) matrica ilitiga tablica 

            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }



            };

            //kako dobiti broj 6
            Console.WriteLine(tablica[1,2]);

            //3d niz

            int[,,] kocka = new int[10, 10, 10]; //moze se pohranitit 10x10 x10 tj 1000 

            //zvjezdane staze , visedimenzionalni nizovi

            int[,,,,,] zvjezdanestaze;

            string grad = "Osijek";
            //ispisi j

            Console.WriteLine(grad[3]);

            Console.WriteLine(grad[grad.Length-1]);

            //char je tip podatka znak od samo jednog znaka i ide pod jednostruke ''

            char znak = 'x';
            Console.WriteLine(znak);
            Console.WriteLine((int)znak); // vraca broj unicode charactera

            int[] niz = { 1, 2, 3, 4, 5 };
            //ispisi sve elemente niza jedno ispod drugog
            Console.WriteLine(niz[0]);
            Console.WriteLine(niz[1]);
            Console.WriteLine(niz[2]);
            Console.WriteLine(niz[3]);
            Console.WriteLine(niz[4]);

            //moj nacin  foreach (int x in niz)
            // {
            //     Console.WriteLine(x);
            // };


            int i = 0;
            i++;
            i += 1;
            i = i + 1;
            ++i;

        }
    }
}
