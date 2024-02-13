using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z02
    {

        public static void Izvedi()
        {
            Console.Write("Unesi prvi cijeli broj : ");
            int prvibroj = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi cijeli broj : ");
            int drugibroj = int.Parse(Console.ReadLine());
            if (prvibroj > drugibroj)
            {
                Console.WriteLine("prvi je veci");

            }
            else
            {
                Console.WriteLine("drugi je veci");
            }

        }
    }
}
