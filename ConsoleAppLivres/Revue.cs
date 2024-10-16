using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLivres
{
    internal class Revue : Livre
    {
        public int Numero {  get; set; }
        public int Annee { get; set; }

        // constructeur 

        public Revue (string titre, string auteur, int nombresPages,int numero , int annee) :base(titre,auteur,nombresPages)
        {
            Numero = numero;
            Annee = annee;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine(/*$" titre du livre {Titre},auteur du livre {Auteur},nombres de pages {NombresPages},*/$"numero de page {Numero},annee {Annee}");
        }
    }
}
