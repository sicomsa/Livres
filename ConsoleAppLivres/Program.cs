using ConsoleAppLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Livre> livres = new List<Livre>();

        Revue revue1 = new Revue ("bel ami","yan simo",200,2345,2000);
        Revue revue2 = new Revue("sous la cendre le feu ", "allan simo", 250, 0045, 2005);
        Revue revue3 = new Revue("une saison blanche et seche ", "mael simo", 300, 2000, 2010);
       /*
        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();*/

        Roman roman1 = new Roman("champions", "martin", 300, "roman");
        Roman roman2 = new Roman("immortel", "rodrigues", 345, "science fiction");
        Roman roman3 = new Roman("renaitre", "angel", 567, "roman");
       /*
        roman1.AfficherDetails();
        roman2.AfficherDetails();
        roman3.AfficherDetails();*/

        livres.Add(revue1);
        livres.Add(revue2); 
        livres.Add(revue3);
        livres.Add(roman1);
        livres.Add(roman2);
        livres.Add(roman3);

        foreach (Livre livre in livres)
        {
            livre.AfficherDetails();
        }





    }
}