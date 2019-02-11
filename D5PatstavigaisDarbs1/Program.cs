using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5PatstavigaisDarbs1
{
    class Program
    {
        static void Main(string[] args)
        {
            PDUzd7();

            Console.ReadLine();
        }

        static void PDUzd1()
        {
            Console.Write("ievadi skaitli:");
            int n = int.Parse(Console.ReadLine());

            if (n % 3 == 0) Console.WriteLine("ievadits skaitlis dalas ar 3");
            else Console.WriteLine("ievadits Nedalas ar 3");

        }

        static void PDUzd2()
        {
            Console.WriteLine("ievadi skaitli:");
            int sk1 = int.Parse(Console.ReadLine());

            for (int i = sk1; i >= 1; i--)           //            vairaku skaitlu izvadisanai - for
            {
                Console.WriteLine(i);
            }
        }

        static void PDUzd3()
        {
            Console.WriteLine("ievadi skaitli:");
            int sk1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sk1; i++)
            {
                if (i == 5)   // vai:  if(!==5) ->  {Console.WriteLine(i);}
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.Write("cikla beigas");
        }

        static void PDUzd4()
        {
            Console.Write("ievadi nedelas dienu:");
            string diena = Console.ReadLine();
            Console.Write("vai ir atvalinajums? -  ");
            string yn = Console.ReadLine();

            switch (diena)
            {
                case "p":
                case "o":
                case "t":
                case "c":
                case "pk":
                    switch (yn)
                    {
                        case "j":
                            Console.WriteLine("modinatajam jazvana 1000");
                            break;
                        case "n":
                            Console.WriteLine("modinatajam jazvana 0700");
                            break;
                    }
                    break;
                case "se":
                case "sv":
                    switch (yn)
                    {
                        case "j":
                            Console.WriteLine("modinatajs off");
                            break;
                        case "n":
                            Console.WriteLine("modinatajam jazvana 1000");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine(" ievadita neatlauta vertiba");
                    break;
            }

        }

        static void PDUzd5()
        {
            Console.WriteLine("ievadi sakuma vertibu A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ievadi beigu vertibu B kas > A:");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)  //lai atseviski neizdarlitu ->  if(i%3==0 {Console.Write("fizz");} if(i%5==0) {console.Write("buzz);} if(i%3!=0 %% i%5!=0) {ConsoleWrite(i);}
                {
                    Console.WriteLine(" FizzBuzz");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(" Buzz");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.Write("cikla beigas");
        }


        static void PDUzd6()
        {

            Console.WriteLine("pieejamas darbibas: ");
            Console.WriteLine("1 - iemaksat");
            Console.WriteLine("2 -pirkt");
            Console.WriteLine("3 - sanemt atlikumu");
            Console.WriteLine("e - partraukt");

            Automats a = new Automats();

            while (true)
            {
                Console.WriteLine("ievadi darbibu: ");
                string darbiba = Console.ReadLine();

                switch (darbiba)
                {
                    case "e":
                        return; //           nevis break!! - break partrauc lidz swich, nevis visu
                    case "1":
                        Console.WriteLine("ievadi summu: ");
                        double summa = double.Parse(Console.ReadLine());
                        a.Iemaksat(summa);
                        break;
                    case "2":
                        a.PirktDzerienu();
                        break;
                    case "3":
                        a.SanemtAtlikumu();
                        break;
                }

            }

        }



        static void PDUzd7()
        {

            Console.WriteLine("uzmini vardu ");
            string zv = "*****";
            Console.WriteLine(zv);
            Console.Write("ievadi varda burtu: ");
            string burts = Console.ReadLine().ToLower();

            string vards = "saule";

            string vards2 = vards;


            bool b = vards.Contains(burts);                           //bool true or false- vai ir tads burts
            Console.WriteLine(" {0} ir minamaja varda", burts, b);


            int index = vards.IndexOf(burts);         //kura poz cip ir meklejamais burts
            Console.WriteLine("    {0}", index + 1);

            /* if (index !=-1)
             {
                 vards2 = vards.Remove(index, 1); //izlaiz uzmineto burtu
             }
             Console.WriteLine(vards2);

             string modified = vards2.Insert(index, "*");   // izlaizta burta vieta liek *
             Console.WriteLine("The modified string: '{0}'", modified);*/

            if (index != -1)
            {
                vards2 = zv.Remove(index, 1); //izlaiz zvaigzni uzmineta burta vieta
            }
            Console.WriteLine(vards2);

            string modified2 = vards2.Insert(index, burts);   // izlaiztaja veita ieleik uzmineto burtu
            Console.WriteLine("The modified string: '{0}'", modified2);


            while (zv != vards)
            {
                Console.Write("ievadi varda burtu: ");
                string burts1 = Console.ReadLine().ToLower();

                switch (burts1)
                {
                    case "z":
                        return;
                    case "a":
                    case "u":
                    case "s":
                    case "l":
                    case "e":
                        int index1 = vards.IndexOf(burts1);
                        if (index1 != -1)
                        {
                            vards2 = zv.Remove(index1, 1); //izlaiz zvaigzni uzmineta burta vieta
                        }
                        Console.WriteLine(vards2);

                        string modified1 = vards2.Insert(index1, burts1);   // izlaiztaja veita ieleik uzmineto burtu
                        Console.WriteLine("The modified string: '{0}'", modified1);
                        
                        for (int i = index1; i <= 1; i++)
                        {
                            Console.WriteLine(vards2);
                        }
                        break;
                }

            }
        }


    }
}



            /*   int uzminamaisSkaitlis = 99;
            while(true)
            {
                Console.WriteLine("uzmini skaitli par kuru es domaju :");
                int a = int.Parse(Console.ReadLine());

                if (a==99)             
                {
                    break;
                }
                else if (uzminamaisSkaitlis > a) 

                    Console.WriteLine("uzminamais skaitlis ir lielaks");
                 else
                    Console.WriteLine("uzminamais skaitlis ir mazaks");
            }
            Console.Write("skaitlis {0} ir uzminets!!!", uzminamaisSkaitlis );*/






