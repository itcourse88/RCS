using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class darbinieks
    {
        public string Vards;
        public string Uzvards;
        public adrese Dzivesvieta;
        public adrese Darbavieta;

        public void Info()
        {
            Console.WriteLine("Darbinieki sauc {0} {1}", Vards, Uzvards);

            Console.WriteLine("Darbinieka dzivesvieta: {0}", Dzivesvieta.PilnaAdrese());
            Console.WriteLine("Darbinieka darbavieta: {0}", Darbavieta.PilnaAdrese());

        }

    }
}
