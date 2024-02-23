using System;

namespace UcenjeCS
{
    internal class Ciklicnaucenje
    {
        public static void Izvedi()
        {
            Console.Write("Unesi broj redova: ");
            int redovi = int.Parse(Console.ReadLine());
            
            Console.Write("Unesi broj stupaca: ");
            int stupci = int.Parse(Console.ReadLine());

            int[,] matrica = new int[redovi, stupci];

            int x = 1;
            int pocetakreda = 0;
            int krajreda = redovi - 1;
            int pocetakstupca = 0;
            int krajstupca = stupci - 1;

            while (x <= redovi * stupci)
            {
                for (int i = krajstupca; i >= pocetakstupca; i--)
                    matrica[krajreda, i] = x++;

                for (int i = krajreda - 1; i >= pocetakreda + 1; i--)
                    matrica[i, pocetakstupca] = x++;

                for (int i = pocetakstupca; i <= krajstupca - 1; i++)
                    matrica[pocetakreda, i] = x++;

                for (int i = pocetakreda; i <= krajreda - 1; i++)
                    matrica[i, krajstupca] = x++;

                pocetakreda++;
                krajreda--;
                pocetakstupca++;
                krajstupca--;
            }

            Console.WriteLine();
            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                     Console.Write("{0,4}", matrica[i, j]);
                }
                Console.WriteLine();
            }          
        }
    }
}
