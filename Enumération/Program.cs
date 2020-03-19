using System;

namespace Enumération
{
    enum Saison
    {
        Printemps,
        Eté,
        Automne,
        Hiver
    }
    class Program
    {
        static void Main(string[] args)
        {
            Saison saisonActuelle = Saison.Hiver;
            Console.WriteLine(saisonActuelle);//enum

            String maSaison = saisonActuelle.ToString();
            Console.WriteLine(maSaison);//string
        }
    }
}
