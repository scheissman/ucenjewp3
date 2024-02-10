using System;

namespace UcenjeCS
{
    internal class Matrica
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi Broj redova: ");
            int redovi = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi broj stupaca: ");
            int stupci = int.Parse(Console.ReadLine());

            int[,] matrica = new int[redovi, stupci];
            int start = redovi * stupci;

            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                    matrica[i, j] = start;
                    start--;
                }
            }

            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
