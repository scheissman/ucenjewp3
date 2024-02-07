using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z04

    {

        public static void Izvedi()
        {
            //program od korisnika trazi da se unese 2 cjela broja, ispisuje sve neparne izmedju ta dva broja

            Console.Write("unesi prvi cijeli broj: ");
            int prvibroj = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi cijeli broj : ");
            int drugibroj = int.Parse(Console.ReadLine());

            if (prvibroj < drugibroj)
            {
                for (int i = prvibroj; i <= drugibroj; i++)
                {   
                    if (i%2 != 0 )
                    Console.WriteLine(i);
                }

            }
            else
            {
                for (int i = prvibroj; i >= drugibroj; i--)
                {
                    if (i % 2 != 0)
                        Console.WriteLine(i);
                }
            }



        }
    }
}
