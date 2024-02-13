using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z05
    {
        public static void Izvedi()
        {
            // Program od korisnika unosi cijeli broj
            // program ispisuje zbroj svih brojeva od 1 do unesenog broja
            // Primjer za 100 će ispisati 5050

            //Console.Write("Unesi cijeli broj : ");
            //int broj = int.Parse(Console.ReadLine());
            //int zbroj = 0;
            //for (int i = 1;  i <= broj; i++)
            //{
            //    zbroj += i;
            //}
            //Console.WriteLine(zbroj );

            // Program unosi cijele brojeve sve dok se ne unese -1
            // Program ispisuje najmanji uneseni broj



            //int najveci = int.MaxValue;

            //for (; ; )
            //{
            //    Console.WriteLine("Unesi cijele brojeve ");
            //    int broj1 = int.Parse(Console.ReadLine());

            //    if (broj1 == -1)
            //        break;

            //    if (broj1 < najveci)
            //        najveci = broj1;
            //}

            //Console.WriteLine(najveci);

            //int maxbroj = int.MaxValue;

            //while (maxbroj != -1)
            //{
            //    Console.Write("Unesi cijeli broj a (-1) za izlaz : ");
            //    int broj2 = int.Parse(Console.ReadLine());
            //    if (broj2 == -1)
            //        break;
            //    if (broj2 < maxbroj)
            //    {
            //        maxbroj = broj2;
            //    }
            //}
            //Console.WriteLine(maxbroj);

            // Program unosi cijeli broj
            // Program ispisuje da li je unseni broj prosti (prim) PRIME (eng) ili ne

            Console.WriteLine("Unesi broj: ");
            int b = int.Parse(Console.ReadLine());
            bool prim = true;
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0)
                {
                    prim = false;
                    break; // za broj 2536562 si uštedio 2536561 iteraciju
                }
            }
            Console.WriteLine(b + " " + (prim ? " JE " : " NIJE ") + "prim broj");



        }

    }
}
