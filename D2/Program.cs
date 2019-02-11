using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //majasDarbs5();
            uzdevums11();

            Console.ReadLine();

        }

        static void majasDarbs5()
        {
            Console.Write("ievadi savu vecumu:");
            int age = int.Parse(Console.ReadLine());

            //== - lieto lai salidzinatu vai ir vienads
            //!= -

            if (age >= 18)
            {
                Console.WriteLine("pilngadiga persona");
            }
            else
            {
                Console.WriteLine("nepilngadiga persona");
            }

        }

        static void uzdevums7()
        {
            Console.Write("ievadi skaitli 1:");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("ievadi skaitli 2:");
            int sk2 = int.Parse(Console.ReadLine());

            if (sk1 == sk2)
            { Console.WriteLine("vienadi"); }
            else
            { Console.WriteLine("nav vienadi"); }

            /*vai viena rinda -> condition ? true : false ->
            Console.Write(sk1==sk2 ? "skaitli vienadi" : "skaitli nav vienadi"); */

            /* && apvieno nosacijumus -> if(sk1==sk2 && sk1==5) ->skaitli ir vienadi un abi ir 5*/

        }

        static void uzdevums8()
        {
            Console.Write("ievadi mēneša pirmos 2 burtus: ");
            string men = Console.ReadLine();
            //  || - nozime vai!
            if (men == "ap" || men == "ju" || men == "se" || men == "no")
            { Console.Write("30 dienas"); }
            else if (men == "fe")
            { Console.Write("28 dienas"); }
            else
            { Console.Write("31 diena"); }

            //cits variants:
            switch (men) // strada atrak ka if - parlec uz konkreto vertibu
            {
                case "ap":
                case "ju":                   //apvienu visus case un pariet uzreiz uz ievadito
                case "se":
                case "no":
                    Console.Write("30dienas");
                    break; // pabeidz konkreto parbaudi, ja nav pa vidu-izvada visus write lidz nakosajam break
                case "fe":
                    Console.Write("28dienas");
                    break;
                default: // ja neviens no case nav istais, nav obligata
                    Console.Write("31dienas");
                    break;
            }

        }

        static void uzdevums9()
        {
            Console.Write("ievadi valsti: ");
            string valsts = Console.ReadLine().ToLower();
            //teksta formatesana:
            Console.Write("valsts {0} galvaspilseta {1}", valsts, "ir ");
            Console.Write("valsts" + valsts + "galvaspilseta ir");

            switch (valsts.ToLower())
            {
                case "igaunija":
                    Console.Write("tallina");
                    break;
                case "somija":
                    Console.Write("helsinki");
                    break;
                case "ukraina":
                    Console.Write("kijeva");
                    break;

            }
        }

        static void uzdevums10()
        {
            Console.Write("ievadi velamo darbibu starp skaitliem: ");
            string op = Console.ReadLine();
            Console.Write("ievadi skaitli 1:");
            int d1 = int.Parse(Console.ReadLine());
            Console.Write("ievadi skaitli 2:");
            int d2 = int.Parse(Console.ReadLine());
           
            switch (op)
            {
                case "+":
                    //Console.Write(d1+d2); - cits veids ka to pasu pierakstit
                    int a = d1+d2;
                    Console.WriteLine("d1+d2=" + a);
                    break;
                case "-":
                    int b = d1 - d2;
                    Console.Write("d1-d2=" + b);
                    break;
                case "*":
                    int c = d1 * d2;
                    Console.Write("d1*d2=" + c);
                    break;
                case "/":
                    float d = d1 / (float)d2;
                    Console.Write("d1/d2=" + d);
                    break;
                default:
                    Console.WriteLine("neatlauta darbiba");
                    break;

            } 
            
            }

        static void uzdevums11()
        {
            Console.Write("ievadi gradus:");
            int gradi = int.Parse(Console.ReadLine());
            Console.Write("ievadi gradu mervienibu: ");
            string m1 = Console.ReadLine().ToUpper(); //ToUpper ja talak izmanto lielos burtus C,K,F
            Console.Write("ievadi jauno gradu mervienibu: ");
            string m2 = Console.ReadLine().ToUpper();

            switch(m1)
            {
             case "C" :
                    switch(m2)
                    {
                        case "K":
                            Console.WriteLine(gradi + 273.15f);
                            break;
                        case "F":
                            Console.WriteLine(gradi * 9 / 5 + 32);
                            break;
                    }
                    break;
             case "K":
                    switch(m2)
                    {
                        case "C":
                            Console.Write(gradi - 273.15);
                            break;
                        case "F":
                            Console.Write(gradi * 9 / 5 - 453.67f);
                            break;
                    }
                    break;
             case "F":
                    switch (m2)
                    {
                        case "C":
                            Console.Write((gradi -32)/1.8f);
                            break;
                        case "K":
                            Console.Write((gradi + 453.67f)/1.8f);
                            break;
                    }
                   break;
              
            }
          
        }

        static void uzdevumsXx()
        {


        }



        }
    }
