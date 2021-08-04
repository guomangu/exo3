using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    class Taboolox:Trie
    {
        public Taboolox()
        {
            
        }

        public List<Voiture> InList(string[,] tab2D)
        {
            List<Voiture> god = new List<Voiture>();
            for (int i = 0; i < tab2D.Length / 3; i++)
            {
                var godmode = new Voiture(tab2D[i, 0], tab2D[i, 1], tab2D[i, 2]);
                //Console.WriteLine(godmode);
                god.Add(godmode);

            }
            return god;
        }
    }
}
