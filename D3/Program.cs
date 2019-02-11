using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    class Program
    {
        static void Main(string[] args)
        {
            //cikliPiemers();
            // skaitlisLidz100();
            //dzimsanasGads();
           // paraSkaitli();
            // uzdevums16();
            //uzdevums18();
           // uzdevums20();
            majasDarbs2_7();
           // majasDarbs2_6v2();

            Console.ReadLine();
        }

        static void cikliPiemers()
        {
            Console.WriteLine("ievadi skaitli:");
            int sk1 = int.Parse(Console.ReadLine());

            for (int i = sk1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;//visu kas ir cikla ietvaros neizpilda un pariet pie nakamas iteracijas(izlaiz posmu)
                }
                Console.WriteLine(i);
            }
            Console.Write("cikla beigas");

            //partrauktu ciklu apstrade
            //if(i==5)
            //{
            //break;
            //}

        }

        static void skaitlisLidz100()
        {
            int summa = 0;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                summa = summa + i; //vai summa+=i
            }
            //summas izvadisanai:
            Console.Write("Summa= {0}", summa);
        }

        static void dzimsanasGads()
        {
            Console.WriteLine("ievadi dzimsanas gadu:");
            int gads = int.Parse(Console.ReadLine());
            //int g = int.Parse(Console.ReadLine()); tad -> for ( ; g <= DateTime.Now.Year; g++)

            /* for (int g = gads; g <= DateTime.Now.Year; g++) //DateTime.Now.Year panem datora gadu
             {
                 Console.WriteLine(g);
             }*/

            while (gads <= DateTime.Now.Year)
            {
                Console.WriteLine(gads);
                gads = gads + 1;
            }

        }

        static void paraSkaitli()
        {
            Console.WriteLine("ievadi skaitli N:");
            int n = int.Parse(Console.ReadLine());
            int summa = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0) //                      % -dalishana-para sk. , nepara -> if(i % 2 !=0)
                {
                    Console.WriteLine(i);
                    summa += i;
                }

            }

        }

        static void uzdevums16()
        {
            Console.WriteLine("ievadi skaitlu N skaitu:");
            int n = int.Parse(Console.ReadLine());
            int summa = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("ievadi {0}, skaitli", i);
                int sk = int.Parse(Console.ReadLine()); //saisinata versija -> summa+=int.Parse(Console.ReadLine());
                summa += sk;
            }
            Console.WriteLine("summa= {0}", summa); //0 norada parametru skaitlis aiz komata kadu vertibu liks 0 vieta - saja gad summa
            Console.WriteLine("videja= {0}", summa / (float)n);
        }

        static void uzdevums18()
        {
            Console.WriteLine("ievadi skaitlu N:");
            int n = int.Parse(Console.ReadLine());

            for (int j = 1; j <= n; j++) //rindai
            {
                for (int i = 1; i <= n; i++) //kollonai
                {
                    Console.Write("#");
                }

                Console.WriteLine("#");


            }

        }

        static void uzdevums19()                            //trijsturis
        {
            Console.WriteLine("ievadi skaitlu N:");
            int n = int.Parse(Console.ReadLine());

            for (int j = 1; j <= n; j++) //rindai
            {
                for (int i = 1; i <= j; i++) //kollonai
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
             for (int j = n-1; j >=1; j--)
                {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }

        static void uzdevums20()                 //       dimants no *
        {
            int N, a, r, sk = 1;            //N-rindu skaits, a- atstarpe,
            Console.WriteLine("ievadi rindu skaitu -");
            N = int.Parse(Console.ReadLine());
            sk = N - 1;
            for (r = 1; r <= N; r++)//sk-N
            {
                for (a = 1; a <= sk; a++)
                    Console.Write(" ");
                sk--;
                for (a = 1; a <= 2 * r - 1; a++)
                    Console.Write("*");
                Console.WriteLine();
            }
            sk = 1;
            for (r = 1; r <= N - 1; r++)
            {
                for (a = 1; a <= sk; a++)
                    Console.Write(" ");
                sk++;
                for (a = 1; a <= 2 * (N - r) - 1; a++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();

        }


        static void majasDarbs2_1()
        {
            Console.Write("ievadi savu vecumu:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 50) Console.WriteLine("vecums parsniedz 50");
            else Console.WriteLine("vecums neparsniedz 50");

        }

        static void majasDarbs2_2()
        {
            Console.Write("ievadi skaitli:");
            int n = int.Parse(Console.ReadLine());

            if (n >= -50 && n <= 50) Console.WriteLine("skaitlis ir robezas no -50 - 50");
            else Console.WriteLine("skaitlis arpus intervala (-50-50)");
        }


        static void majasDarbs2_3()
        {
            Console.Write("ievadi skaitli:");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) Console.WriteLine("ievadits ir para skaitlis");
            else Console.WriteLine("ievadits ir nepara skaitlis");
        }


        static void majasDarbs2_4()                         //static void MinMax() int sk1=5; intsk2=10; int min; if(sk1<sk2){min=sk1;}else{min=sk2}
        {
            Console.Write("ievadi skaitli 1:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("ievadi skaitli 2:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("ievadi skaitli 3:");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("skaitlis 1 ir lielakais -"+a);
                }
                else
                {
                    Console.WriteLine("skaitlis 3 ir lielakais - "+c);
                }
            }
            else if (b > c)
                Console.WriteLine("skaitlis 2 ir lielakais - "+b);
            else
                Console.WriteLine("skaitlis 3 ir lielakais - "+c);
            if (a < b)
            {
                if (a < c)
                {
                    Console.WriteLine("skaitlis 1 ir mazakais - " + a);
                }
                else
                {
                    Console.WriteLine(" skaitlis 3 ir mazakais - " + c);
                }
            }
            else if (b < c)
                Console.WriteLine("skaitlis 2 ir mazakais - " + b);
            else
                Console.WriteLine("skaitlis 3 ir mazakais -" + c);
            }
        // int min = 

        static void majasDarbs2_5() //parverst katru skaitli par tekstu un katru burtu saskaita
        {                                   
            Console.Write("ievadi skaitli :");
            int a = int.Parse(Console.ReadLine());
           int sum = 0;
            while (a != 0)
            {
                sum += a % 10; // -> sum= sum+ a / 10
                a /= 10; //         -> a = a/10                x /= y -> ts pats kas  x= x / y
            }
            Console.WriteLine(" skaila ciparu summa ir: "+sum);
        }

        static void majasDarbs2_6()
        {
            int summa = 0;
            for (; ; )                  //-> bezgaligs cikls tas pats kas while(true)
            {
                Console.WriteLine("ievadi skaitli :");
                int a = int.Parse(Console.ReadLine());
                summa += a;
                if (a == 13)
                {
                     break;
                }
            }
            Console.Write("Summa= {0}", summa);
        }

        static void majasDarbs2_6v2()
        {
            int summa = 0;
            while (true)                
            {
                Console.WriteLine("ievadi skaitli :");
                int a = int.Parse(Console.ReadLine());
                summa += a;
                if (a == 13)
                {
                    break;
                }
            }
            Console.Write("Summa= {0}", summa);
        }

        static void majasDarbs2_7()
        {
            int uzminamaisSkaitlis = 99;
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
            Console.Write("skaitlis {0} ir uzminets!!!", uzminamaisSkaitlis );
        }





        }

    }

 
