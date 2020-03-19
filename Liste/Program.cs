using System;
using System.Collections.Generic;//ATTENTION List<> marche pas sans ca 

namespace Liste
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<string> eleve = new List<string>() {"Archibald", "Jean-Eugène", "Kevin-Didier", "Sharon"};

            for (int i = 0; i < eleve.Count; i++)
            {
                Console.WriteLine(eleve[i]);
            }

            Console.WriteLine("\n");

            eleve.Add("Guillaume");
            eleve.Add("Chew Long Kok");
            eleve.Add("Jed I Knight ");
            eleve.Add("Sam Sung");

            for (int i = 0; i < eleve.Count; i++)
            {
                Console.WriteLine(eleve[i]);
            }
            Console.WriteLine("\n");

            eleve.Remove("Archibald");
            eleve.Remove("Sharon");
            eleve.Remove("Sam Sung");

            for (int i = 0; i < eleve.Count; i++)
            {
                Console.WriteLine(eleve[i]);
            }
            Console.WriteLine("\n");

            eleve.Sort();

            for (int i = 0; i < eleve.Count; i++)
            {
                Console.WriteLine(eleve[i]);
            }
            Console.WriteLine("\n");

            int nombreEleves = eleve.Count;
            Console.WriteLine("Il y a " + nombreEleves + " eleves dans la classe");
        }
    }
}
