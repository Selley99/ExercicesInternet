using System;

namespace Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] monTab = new int[5];
            monTab[0] = 45;
            monTab[1] = -23;
            monTab[2] = 900;
            monTab[3] = 466;
            monTab[4] = 66;

            for (int i = 0; i < monTab.Length; i++) {
                Console.WriteLine(monTab[i]);
            }

        }
    }
}
