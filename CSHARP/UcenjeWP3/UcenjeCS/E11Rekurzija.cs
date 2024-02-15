using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Rekurzija
    {
        public static void Izvedi()
        {
            //zbrojte prvih 100 brojeva
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
            Console.WriteLine(Zbroj(100));

        }






        private static int Zbroj(int broj)
        {
            //svaka rekurzija mora imati uvijet prekida rekurzije 
            if (broj == 1)
            {
                return 1;
            }
            return broj + Zbroj(broj - 1);//rekurzija- metoda zove samu sebe
        }

    }   
}
