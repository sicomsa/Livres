using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLivres
{
    internal class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombresPages { get; set; }

        // constructeur 
        
        public Livre (string titre, string auteur,int nombresPages)
        {
            Titre = titre;
            Auteur = auteur;
            NombresPages = nombresPages;
        }

        public virtual void AfficherDetails()
        {
            Console.WriteLine($" titre du livre {Titre},auteur du livre {Auteur},nombres de pages {NombresPages}");
       
        }
    }
}
