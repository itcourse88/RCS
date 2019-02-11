using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Program
    {
        static void Main(string[] args)
        {
           // piemers();
         //  aplis();
            uzdevums23();
          //  uzdevums24();
                                                    //6.
            Console.ReadLine();

        }

        static void piemers ()                       //5. 
        {
            kvadrats kv1 = new kvadrats(5); //       7.   izveidojas objekts tikai tagad - iepriekseja klase kvadrats tikai planojums
           // kv1.malasGarums = 5;  ieliek() nodefinejot konst.kvadrats lpp 112 //      8.pieskir vertibu

            int laukums = kv1.laukums();//          9. izsauc aprekinu funkcijas
            int perimetrs = kv1.perimetrs();

            Console.WriteLine("Lukums = {0}", laukums);  //10. izvada rezultatus
            Console.WriteLine("Perimetrs = {0}", perimetrs);


            //paraleli citam kvadratam aprekina, veidojot jaunu objektu:
           kvadrats kv2 = new kvadrats(10); // kontruktors-specifiska funkcija lai izsauktu objektu
            kv2.KonsolesIzvade();



            kvadrats kv3 = new kvadrats()
            {
                malasGarums = 5,
                //var uzskaitit visas citas ipasibas,ja liek {}
            };


            kvadrats.FuigurasNosaukums(); 

        }

        static void aplis()
        {
            aplis a1 = new aplis();

            Console.WriteLine("ievadi apla radiusu: ");
            int Radiuss = int.Parse(Console.ReadLine());
            
            a1.Radiuss = Radiuss;

            a1.Krasa = "zila";

            a1.Laukums();
            a1.Perimetrs();
            a1.KrasasIzvade();
           

        }

        static void uzdevums23()
        {
            darbinieks darbinieks = new darbinieks();
            darbinieks.Vards = "Aigars";
            darbinieks.Uzvards = "Liepa";
            darbinieks.Dzivesvieta = new adrese();
            darbinieks.Dzivesvieta.Valsts = " Latvija";
            darbinieks.Dzivesvieta.Pilseta = "Riga ";
            darbinieks.Dzivesvieta.Iela = " Brivibas";
            darbinieks.Darbavieta = new adrese();
            darbinieks.Darbavieta.Valsts = " Latvija";
            darbinieks.Darbavieta.Pilseta = "Riga ";
            darbinieks.Darbavieta.Iela = " Brivibas";

            darbinieks.Info();

        }

        static void uzdevums24()
        {


        }


    }
}
