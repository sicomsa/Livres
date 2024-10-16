using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLivres
{
    internal class Roman : Livre
    {
        public string Genre { get; set; }

        // constructeur 

        public Roman (string titre, string auteur, int nombresPages,string genre)  : base(titre, auteur, nombresPages)
        {
            Genre = genre;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($" titre du livre {Titre},auteur du livre {Auteur},nombres de pages {NombresPages},genre livre {Genre}");
        }

    }
}
