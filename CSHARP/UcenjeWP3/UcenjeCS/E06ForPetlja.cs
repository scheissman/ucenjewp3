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

            //petlja se moze preskociti 

            for (int i = 0; i <10; i++)
            {

                if (i == 3)
                {
                    continue;

                }
               
                    Console.WriteLine(i);
                }
            //petlja se moze prekinuti sa break 
            for (int i = 0; i < 10; i++)
            {
                if (i == 3) { break; }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; i++)
                {   //vanjska varijabla se prekida sa labelom 
                    goto labela;
                    break; //prekida unutarnju petlju varojabla j
                }

            }
            labela:
            Console.WriteLine("nastavak nakon vanjske petlje ");

            //beskonacna petlja 

            for(; ; )
            {
                Console.WriteLine(new Random().NextInt64 (1,100));
                break;
            }
            // 9 različitih načina zbrajanja prvih 100 brojeva

            // int i, s=0; for(i=1;i<=100;i++) s+=i;

            // int i, s; for(i=1, s=0;i<=100; s+=i, i++);
            //
            // int i=1, s=0; for( ; i<=100; i++){ s+=i; }
            //
            // int i, s=0; for(i=1; ; i++){ if(i<=100) s+=i; else break;}
            //
            // int i, s=0; for(i=1;i<=100; ){ s+=i; i++;}
            //
            //int i, s=0; for(i=1; ; ){ if(i<=100) {s+=i; i++;} else break;}
            //
            // int i=1, s=0; for( ; i<=100 ; ){ s+=i; i++;}
            //
            // int i=1, s=0; for( ; ; i++){if(i<=100)  s+=i; else break;}
            //
            // int i=1, s=0; for( ;  ; ){if(i<=100) {s+=i; i++;} else break;} 
            //		
        }
    }
}
