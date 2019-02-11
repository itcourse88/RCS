using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class aplis
    {
        /// <summary>
        /// apla kras
        /// </summary>
        public string Krasa; 
        /// <summary>
        /// apla radiuss
        /// </summary>
        public int Radiuss;
                             
        public void Perimetrs()
        {
            Console.WriteLine("Perimetrs = {0}",2*Math.PI*Radiuss);
        }
       
        public void Laukums()
        {
            Console.WriteLine("Apļa laukums = {0}", Math.PI * Radiuss * Radiuss);
        }

        public void KrasasIzvade()   
        {
            Console.WriteLine("Krāsa= {0}", Krasa);
        }

       /* internal int Perimetrs()
        {
            throw new NotImplementedException();
        }*/
        //4 klases izsaukums otra lapa
    }
}
