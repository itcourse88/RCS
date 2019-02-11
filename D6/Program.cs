using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class Program
    {
        static void Main(string[] args)
        {
            // masivs();
            uzdevums26();
            // Saraksts();

            Console.ReadLine();

        }

        static void masivs()
        {
            int sk1;
            int sk2;

            int[] skaitli = new int[5];  //masivs[] ar 5 elementiem - skitliem int

            skaitli[0] = 1;
            skaitli[1] = 2;
            skaitli[2] = 3;
            skaitli[3] = 4;
            skaitli[4] = 5;
            // skaitlis[5] = 6; //izmetis kludu, jo sakotneji nodefinetas 5 vertibas - IndexOutOfRange

            int skaitlis = skaitli[3];           //bus4   ar[] pieklust konkretam elemtam kas atrodas ieks[]

            for (int i = 0; i < skaitli.Length; i++) //                izvada visu masivu
            {
                int vertiba = skaitli[i];
                Console.WriteLine(vertiba);
            }


            foreach (int vertiba in skaitli)         //         foreach                    funkcija masiviem ari izvada visu masivu, tas pats kas for ciklam
            {
                Console.WriteLine(vertiba);
            }
        }


        static void uzdevums25()
        {
            Console.WriteLine("ievadi skaitli:");
            int n = int.Parse(Console.ReadLine());

            int[] masivs = { 0, 10, 20, 30, 40, 50 }; //                ja zinamas masiva vertibas ieprieks

            bool irAtrasts = false;                     //      bool          var pieskirt 2 vertibas true un false
            for (int i = 0; i < masivs.Length; i++)//      ->cikls kas iet cauri masivam
            {
                if (masivs[i] == n)
                {
                    Console.WriteLine("skaitlis ir pozicija {0}", i);
                    irAtrasts = true;
                    break;
                }
            }
            if (irAtrasts == false)        //vai -> if(!irAtrasts)
                Console.WriteLine("skaitla nav masiva");

            irAtrasts = masivs.Contains(n);  //                    Contains-                iebuveta funkcija, kas dara ieprieks uzrakstitio, masiva mekle defineto
        }

        static void uzdevums26()
        {                                               //int skaits=5;
            int[] masivs = new int[5];                  // int[]masivs = new int [ skaits]

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write("ievadi {0}. skaitli: ", i);
                masivs[i] = int.Parse(Console.ReadLine()); //   masivs[i] - katra ievadita vertiba tiek pievienota gala masivam
            }

            for (int i = masivs.Length - 1; i >= 0; i--) //      i= masivs.Length - 1 !!!!!   -> lai pieklutu visam 5 masiva vertibam
            {
                Console.WriteLine(masivs[i]);
            }

        }




        static void Saraksts()
        {
            List<int> saraksts = new List<int>();

            // for (int i = 1; i <=5; i++)
            while (true)
            {
                Console.Write("ievadi skaitli (vai 0 lai partrauktu): ");
                string vertiba = Console.ReadLine();
                if (String.IsNullOrEmpty(vertiba))
                { break; }

                int skaitlis = int.Parse(vertiba);
                if (skaitlis == 0)
                { break; }

                saraksts.Add(skaitlis);

                //   saraksts.Add(int.Parse(Console.ReadLine()));
            }

            // int ekementuSkaits = saraksts.Count;
            saraksts.Reverse();                                              //apgriez sarkstu
            Console.WriteLine(String.Join(" ,", saraksts));                  //String.Join - iebuveta funkcija

        }

        static void uzdevums27()
        {
            List<int> skaitli = new List<int>();

            while (true)
            {
                Console.Write("ievadi skaitli (vai 0 lai partrauktu): ");
                string vertiba = Console.ReadLine();
                if (String.IsNullOrEmpty(vertiba))
                { break; }

                int skaitlis = int.Parse(vertiba);
                if (skaitlis == 0)
                { break; }

                skaitli.Add(int.Parse(vertiba));
            }
            int skaits = 0;
            foreach (int skaitlis in skaitli)
            {
                if (skaitlis == 5)
                {
                    skaits++;
                }

            }
            Console.WriteLine(" skaitlis 5 ir atrasts {0} reizes", skaits);


            //2.variants
            skaits = skaitli.Count(sk => sk == 5);         //                    Count --pirms => define jaunu mainigo, ko slidzina ar vertibu (seko nosacijums), ja nosacijums true-vertiba tiek pieskaitita, ja false,netiek
            Console.WriteLine(" skaitlis 5 ir atrasts {0} reizes", skaits);
        }

        static void uzdevums27_2()
        {
            List<int> skaitli = new List<int>();

            while (true)
            {
                Console.Write("ievadi skaitli (vai 0 lai partrauktu): ");
                string sk = Console.ReadLine();
                if (String.IsNullOrEmpty(sk))
                { break; }

                int sk1 = int.Parse(sk);
                if (sk1 == 0)
                { break; }

                skaitli.Add(int.Parse(sk));
            }

            int min = skaitli.Min();
            Console.WriteLine(" mazakais skaitlis ir {0}  ", min);
            int max = skaitli.Max();
            Console.WriteLine(" lielakais ir skaitlis {0} ", max);

        }


    }
}
