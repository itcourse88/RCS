using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_piemeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
           // TekstaIzvade();
            tekstaIzvadeArParametru("teksts no funkcijas parametra");
          //  tekstaIevade();
           // vecumaIevade();

            Console.Read();

            //kometars

            /*
             vairakas rindas
             */             
        }

        static void TekstaIzvade()
        {
            Console.WriteLine("Funkcijas izvadits teksts");
        }

        static void tekstaIzvadeArParametru(string teksts)
        {
            Console.WriteLine("parametra izvade " +teksts);
        }

        static void tekstaIevade()
        {
          //izvada
            Console.Write("ievadi savu vārdu - ");
            //ievada
            string Vārds = Console.ReadLine();
            Console.Write("ievadi savu uzvārdu - ");
            string uzvārds = Console.ReadLine();
                  
            Console.Write("Tevi sauc- " + Vārds+" " + uzvārds);
        }

        static void vecumaIevade()
         {
            Console.Write("ievadi savu vecumu:");
            //string vecums = Console.ReadLine();
            //int skaitlis = Convert.ToInt32(vecums); vai:
            int skaitlis = int.Parse(Console.ReadLine())+1;
            //skaitlis = skaitlis + 1; vai
           // skaitlis += 1;

            Console.Write("pēc gada tev būs:"+skaitlis);

           }

    }
}
