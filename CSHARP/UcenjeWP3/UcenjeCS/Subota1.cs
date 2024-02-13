using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UcenjeCS
{
    public class Subota1
    {
        public static void Izvedi()
        {
            // for(int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds());
            //     if (i == 4)
            //     {
            //         break;
            //     }
            //     Console.WriteLine("\a");
            //     Thread.Sleep(1000);  // usporavanje rada programa - spavaj jednu sekundu
            // }
            // int t = 2147483647;

            // long l = t+1; // implicitno

            // l = 2147483648247246276;

            // Console.WriteLine(l);

            // t = (int)l; // eksplicitno

            // Console.WriteLine(t);
            // Program unosi tri cijela broja i ispisuje ih jedan pored drugoga

            // Program unosi imena triju gradova malim slovima
            // Ako svako ime grada počinje slovo o
            // ispisuje SUPER
            // inače ispisuje OK
            // Rješenje 1
            // System.Console.WriteLine("unesi ime 1 grada");
            // string a = Console.ReadLine();
            // System.Console.WriteLine("unesi ime 2 grada");
            // string b = Console.ReadLine();
            // System.Console.WriteLine("unesi ime 3 grada");
            // string c = Console.ReadLine();

            // if (a[0]== 'o' && b[0] =='o' && c[0] == 'o'){
            //     System.Console.WriteLine("SUper");
            // }
            // else{
            //     System.Console.WriteLine("OK");
            // }
            // Rješenje 2
            // string[] gradovi = new string[3];
            // for(int i=0; i<3; i++)
            // {
            //    Console.Write("Unesi ime " + (i+1) + ". grada: ");
            //     gradovi[i] = Console.ReadLine();
            // }
            // bool pocinju = true;
            // foreach(string grad in gradovi)
            // {
            //    if (grad[0] != 'o')
            //    {
            //        pocinju = false;
            //        break;
            //    }
            // }
            // Console.WriteLine(pocinju ? "SUPER" : "OK");

             // Rješenje 3 - DOBRA PRAKSA (Best practice)
            // string grad;
            // bool pocinje=true;
            // for(int i = 0;i < 3;i++)
            // {
            //    Console.Write("Unesi ime " + (i + 1) + ". grada: ");
            //    grad = Console.ReadLine();
            //    if (grad[0] != 'o')
            //    {
            //        pocinje = false;
            //        break;
            //    }
            // }
            // Console.WriteLine(pocinje ? "SUPER" : "OK");

            // Kreirajte KN/EUR konverzija kalkulator
            // int bira;

            // while(true){
            //     System.Console.WriteLine("Dobrodosli u kn eur kalk, izaebri 1 za kn eur a 2 za eurkn");
            //      bira = int.Parse(Console.ReadLine());
            //      if (bira == 1 || bira == 2){
            //         break;
            //      }
            //      else{
            //         System.Console.WriteLine("neispravan unos");
            //      }
            // }
            
            // double iznos;
            // // Console.WriteLine("Unesi iznos u " + (bira ==1 ? "kunama" : "eurima") + ": ");
            // // iznos = double.Parse(Console.ReadLine());
            // // Console.WriteLine(bira == 1 ? iznos / 7.5345 : iznos * 7.5345);

            // if (bira == 1){
            //     System.Console.WriteLine("unesi iznos u kunama");
            //     iznos = double.Parse(Console.ReadLine());
            //     iznos = Math.Truncate((iznos/ 7.5354)*100)/100;
            //     System.Console.WriteLine($"iznos u eurima je {iznos}");}
            // else 
            // {
            //     System.Console.WriteLine("unesi iznos u eurima");
            //     iznos = double.Parse(Console.ReadLine());
            //     iznos = iznos * 7.5354;
            //     System.Console.WriteLine($"iznos u kunama je {iznos}");
                
            // }
        
            // Napravite program koji će puknut prilikom izvođenja
            // a biti će sintaksno ispravan

            // int[] array = new int[1];
            // for (int i = 0; i <= 3; i++ ){
            //     System.Console.WriteLine("Unesi neki broj , sigurno ces pogrjesiti");
            //     int broj = int.Parse(Console.ReadLine());
            //     array[i] += broj;

            // }

            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Edunova Osijek");
            Console.ResetColor();
            Console.WriteLine("🎁");




            









        }
    }
}