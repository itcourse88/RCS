using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzdevums2();
            //uzdevums3();
            uzdevums5();
            //uzdevums6();
            //majasDarbs3();

            Console.Read();
        }
        static void uzdevums2()
        {
            Console.Write("ievadi 1 skaitli:");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("ievadi 2. skaitli:");
            int sk2 = int.Parse(Console.ReadLine());

            int summa = sk1 + sk2;
            int starpiba = sk1 - sk2;
            int reiz = sk1 * sk2;
            //decimalskaitliem izmanto float
            float dal = sk1 / (float)sk2;
            Console.WriteLine("summa ir=" + summa);
            Console.WriteLine("starpiba ir=" + starpiba);
            Console.WriteLine("reizinajums ir=" + reiz);
            Console.WriteLine("dalijums ir=" + dal);

         }
        static void uzdevums3()
        {
            Console.Write("skaitlis 1");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("skaitlis 2");
            int sk2 = int.Parse(Console.ReadLine());
            Console.Write("skaitlis 3");
            int sk3 = int.Parse(Console.ReadLine());

            int reiz = sk1 * sk2 * sk3;
            Console.WriteLine("tris skaitlu reizinajums ir :" + reiz);
        }
        static void uzdevums5()
        {
            Console.Write("gradi pec celsija - ");
            float sk1 = float.Parse(Console.ReadLine());

            //lai daļu uzskatītu par daļskaitli-galā pieliek f, vai priekšā iekavās (float)
            float kelvina = sk1 + 273.15f;
            Console.WriteLine("kelvina grādi =" + kelvina);
            float farenheita = sk1 * 9 / 5 + 32;
            Console.WriteLine("farenheita gradi=" + farenheita);

        }
        static void uzdevums6()
        {
            Console.Write("skaitlis 1=");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("skaitlis 2=");
            int sk2 = int.Parse(Console.ReadLine());
            Console.Write("skaitlis 3=");
            int sk3 = int.Parse(Console.ReadLine());
            Console.Write("skaitlis 4=");
            int sk4 = int.Parse(Console.ReadLine());

            float average = (sk1 + sk2 + sk3 + sk4) / 4f;
            Console.WriteLine("videja vertiba=" + average);
        }




        static void majasDarbs1()
        {
            Console.WriteLine("  "+"*");
            Console.WriteLine(" " + "***");
            Console.WriteLine("*****");
        }
        static void majasDarbs2()
        {
            Console.Write("vards 1=");
            string Vards1 = Console.ReadLine();
            Console.Write("vards 2=");
            string Vards2 = Console.ReadLine();
            Console.Write("vards 3=");
            string Vards3 = Console.ReadLine();
            Console.Write(Vards1 + "," + Vards2 + ","+Vards3);
        }
        static void majasDarbs3()
        {
            Console.Write("ievadi skaitla a vertibu:");
            int a = int.Parse(Console.ReadLine());

           /* Console.WriteLine(a + 5); a*=vai+= vai-= -> maina a vertibu no iepriekseja
            
            a=a+1 tas pats kas a+=1 tas pats kas a++ tas pats kas ++a - vertibu palielina pa 1

            Console.WriteLine(a += 5);
            Console.WriteLine(a -= 3);*/


           int a5 = a + 5;
           int a3 = a - 3;
           int ar = a * 2;
           int a1 = a + 1;
            a = a++;
        
            Console.WriteLine("a+5=" + a5);
            Console.WriteLine("a-3=" + a3);
            Console.WriteLine("a*2=" + ar);
            Console.WriteLine("a+1=" + a1);
            Console.WriteLine("a++=" +a);
        }

        static void majasDarbs4()
        {
            Console.Write("ievadi vardu:");
            string input = Console.ReadLine();
            //string input = Console.ReadLine().ToUpper();-lai to pasu ierakstitu 1 rinda
            string choice = input.ToUpper();
            Console.WriteLine(choice);
        }

        static void majasDarbs5()
        {
            Console.Write("ievadi savu vecumu:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18) Console.WriteLine("pilngadiga persona");
            else Console.WriteLine("nepilngadiga persona");
                       
        }
    }
}
