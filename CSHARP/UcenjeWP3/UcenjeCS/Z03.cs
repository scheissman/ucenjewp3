using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z03
    {

        public static void Izvedi()
        {
            // Program unosi tri cijela broja
            // program ispisuje najmanji
            // DZ
            Console.Write("Unesi prvi cijeli broj : ");
            int prvibroj = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi cijeli broj : ");
            int drugibroj = int.Parse(Console.ReadLine());
            Console.Write("Unesi treci broj ");
            int trecibroj = int.Parse(Console.ReadLine());

            if ((prvibroj < drugibroj) && (prvibroj < trecibroj))
            {
                Console.WriteLine($"prvi broj {prvibroj} je najmanji ");
            }
            else if ((drugibroj < prvibroj) && (drugibroj < trecibroj))
            {
                Console.WriteLine($"Drugi broj {drugibroj} je najmanji ");
            }
            else
            {
                Console.WriteLine($"treci broj {trecibroj} je najmanji ");
            }







        }



    }
}
