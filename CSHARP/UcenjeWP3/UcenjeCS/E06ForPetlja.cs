using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        public static void Izvedi()
        {

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] niz = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            //for (int i = 0; i < niz.Length; i++)
            //{
            //    Console.WriteLine(niz[i]);
            //}

            //foreach (int i in niz)
            //{
            //    Console.Write(i+" ");
            //}

            ////ispisi sve parne brojeve od 3 do 43

            //for (int i = 3; i <= 43; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////zbroj prvih 100 brojeva
            //int zbroj = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    zbroj += i;

            //}
            //Console.WriteLine(zbroj);

            ////ispisi sve brojeve od 78 do 4
            //for (int i = 78; i >= 4; i--)
            //{
            //    Console.WriteLine(i);
            //}

            ////ispisi svaki 7. broj od 1 do 100
            //for (int i = 0; i <= 100; i += 7)
            //{
            //    Console.WriteLine(i);
            //}

            ////ispisi brojeve od  1 do 20 jedno porkaj drugog

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i+" ");
            //}

            //petlje se mogu ugnjezditi

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i*j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
