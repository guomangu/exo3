using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tab2D = { 
                { "2098", "Peugeot", "307" }, 
                { "1987", "Renault","Espace" }, 
                { "1203", "Lancia", "Dedra" }, 
                { "3049", "Bmw", "324d" }, 
                { "1500", "Peugeot", "406" }, 
                { "2500", "Ford", "Mondeo" }
            };



            Afficher bonjour = new Afficher();
            List<Voiture> god;

            god=bonjour.InList(tab2D);
                bonjour.Affiche(god);
                bonjour.Trier(god);
                bonjour.Affiche(god);
                bonjour.CompDirect(god);




            Console.ReadKey();
        }
    }
}