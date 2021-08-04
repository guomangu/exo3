using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECAsport
{
    class Program
    {
        static void Main(string[] args)
        {
            SportIndiv spin = new SportIndiv("Emma Igelstrom", " 1 min 05 sec 11/100", "Stockholm", new DateTime(2003,4,10), "100m brasse dames");
            Console.WriteLine(spin);

            Sport spo = new Sport("Petunk");
            Console.WriteLine(spo);
            spo.NewTypeSport("Nanoballs");
            Console.WriteLine(spa);

            SportEquip spek = new SportEquip("Valenciennes", "5", "basket féminin");
            Console.WriteLine(spek);
            SportEquip spok = new SportEquip();
            Console.WriteLine(spak);

            Console.WriteLine(spak.Gagne());






            Console.ReadKey();
        }
    }
}
