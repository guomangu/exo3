using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    class Afficher:Taboolox
    {
        public Afficher()
        {

        }


        public void Affiche(List<Voiture> _god)
        {
            Console.WriteLine("^_^ BoNjOuR ^_^");
            foreach (var item in _god)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
    }
}
