using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class kvadrats //veic visus aprekinu lai ievaditam kvadrat malas garumam aprekina ta laukumu un perimetru
    {
        public int malasGarums; //        1.                   īpašība
                                // pieliek klat public, lai varētu nodefinētās īpašības izmantot citās klasēs-šajā gad. D4

        public kvadrats(int mala) //  *112     konstruktors - nosaka vertibas kas nepieciesamas lai izveidotu objektu lai 5 ieliktu iekavas programma
        {                                       //var but vairāki parametri-atdala ar ;
            malasGarums = mala;
            //this.malasGarums = malasGarums;//this nosaka ka tiek izmantots klases galvenais malas garums, var arī saukt atšķirīgi katrā vietā
        }


        public kvadrats() //bez parametra -izsauks, ja program f-jai nav parametra, ja ir,tad pirmo
        {
            
        }


        public int laukums() //                2.             funkcija
        {
            return malasGarums * malasGarums; //    3.  return-lai atgrieztu vertibu no funkcijas
        }

        public int perimetrs()  //        4.(cita funkcija ja vajag)      publiskās funkcijas raksta ar lietu burtu, bet stradas programma ja bus ari ar mazo
        {
            return malasGarums * 4;     //    5.
        }

        public void KonsolesIzvade() // void neko neatgriež, ja lietotu int būtu arī return jābūt-kkas jaatgriež. nekur citur neparadas-tiek izvadita lietotajam un pazud
        {
            Console.WriteLine("Lukums = {0}", laukums());
            Console.WriteLine("Perimetrs = {0}", perimetrs());
        }

        public static void FuigurasNosaukums()// static funkcija neizsauc objektu vertibas, bet versas pie visas klases. statiska funkcija-izsauksanai nevajag lietot NEW prieksa
        {                                       //static lieto palīgfunkcijām
            Console.WriteLine("sis ir kvadrats");

        }

    }
}
