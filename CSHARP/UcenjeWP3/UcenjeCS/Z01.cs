using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z01
    {
        public static void Izvedi()
        {
            // Program od korisnika unosi cijeli broj
            // Ako je uneseni broj paran ispisuje SUPER
            // inače ispisuje OK
            Console.WriteLine("unesi neki cijeli broj ");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 0)
            {
                Console.WriteLine("broje je paran(super)");
            }
            else
            {
                Console.WriteLine("broj je neparan(ok)");
            }

            }

    }
}
