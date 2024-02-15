using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UcenjeCS
{
    internal class E10Metode

    {
        //static oznacava da metodu mogu pozvati na klasi 
        //public se vidi u svim klasama 

        public static void Izvedi()
        {
        
            Tip1(); //pozivamo metodu imena Tip1
            //sad je opet zovemo 
            Tip1();

            Tip2("zdenko ");
            Tip2("mirlsav", "blazevic");

            Tip3(); //metoda ce se izvesti ali to ode u "zaborav"
            Console.WriteLine(Tip3());

            Console.WriteLine(Tip4(2,77));


        }
        //4 razlicita nacina kreiranja "vrste" metoda ucimo 
        //tip1 - metoda ne prima parametre i ne vraca vrijednost
        //ovdje je deklarirana i napisana
        //private se vidi samo u trenutnoj klasi

        private static void Tip1() //
        {

            Console.WriteLine("hello iz prve metode koja ne prima nista i ne vraca nista");
        }

        //tip2 metoda prima parametre i ne vraca vrijednost, ako nema ispred static void nacina pristupa onda je private
        static void Tip2(string ime)
        {
            Console.WriteLine("dobar dan " + ime);



        }
        //naziv metode ne mora biti jedinstven 
        //potpis metode je ime + lista parametara
        //metod signature
        //metod overloading
        static void Tip2(string ime, string prezime)
        {
            Console.WriteLine("dobar dan " + ime +" "+ prezime);
        }
        //tip 3 metoda ne prima parametre i vraca vrijednost
       // internal je vidljiv u ovom namespacu (folderu)
        internal static int Tip3()
        {
            return 7;
        }

        //tip 4 NAJBITNIAJ metoda prima parametre i vraca vrijednost
        //protected je vidljiv u ovoj klasi i u svim podklasama OOP kasnije
        /// <summary>
        /// primjer metode koja prima 2 parametra i vraca vrijednost
        /// </summary>
        /// <param name="odbroja">prvi primljeni parametar od kojeg se krece</param>
        /// <param name="dobroja"> drugi primljeni parametar do kojeg se ide <=   </param>
        /// <returns> vraca zbroj svaka 2 broja izmedju primljenih parametara </returns>
        protected static int Tip4(int odbroja, int dobroja)
        {
            int suma = 0;
            for (int i = odbroja; i <= dobroja ; i+=2)
                {
                suma += i;
            }
            return suma;




        }


    }
}
