using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Nobel_dij
{
    class Program
    {
        static List<Dij> dijjak = new List<Dij>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat03();
            Feladat04();
            Fealdat05();
            Feladat06();
            Feladat07();
            Feladat08();

            Console.WriteLine("Program vége!");
            Console.ReadKey();
        }

        private static void Feladat08()
        {
            Console.WriteLine("8. Feladat: orvosi.txt");
            StreamWriter sw = new StreamWriter("orvosi.txt", false, Encoding.UTF8);
            foreach (Dij dij in dijjak)
            {
                if (dij.Tipus == "orvosi")
                {
                    sw.WriteLine($"{dij.Ev};{dij.Knev};{dij.Vnev}");
                }
            }
            sw.Close();
        }

        private static void Feladat07()
        {
            int fizikai = 0;
            int kemiai = 0;
            int orvosi = 0;
            int irodalmi = 0;
            int beke = 0;
            int kozgazdasagtani = 0;

            Console.WriteLine("7. Feladat:\t");
            foreach (Dij dij in dijjak)
            {
                if (dij.Tipus == "fizikai")
                {
                    fizikai++;
                }
                if (dij.Tipus == "kémiai")
                {
                    kemiai++;
                }
                if (dij.Tipus == "orvosi")
                {
                    orvosi++;
                }
                if (dij.Tipus == "irodalmi")
                {
                    irodalmi++;
                }
                if (dij.Tipus == "béke")
                {
                    beke++;
                }
                if (dij.Tipus == "közgazdaságtani")
                {
                    kozgazdasagtani++;
                }
            }
            Console.WriteLine($"\t fizikai:\t\t{fizikai}db");
            Console.WriteLine($"\t kémiai:\t\t{kemiai}db");
            Console.WriteLine($"\t orvosi:\t\t{orvosi}db");
            Console.WriteLine($"\t irodalmi:\t\t{irodalmi}db");
            Console.WriteLine($"\t béke:\t\t\t{beke}db");
            Console.WriteLine($"\t közgazdaságtani:\t{kozgazdasagtani}db");

        }

        private static void Feladat06()
        {
            Console.WriteLine("6. feladat:\t");
            foreach (Dij dij in dijjak)
            {
                if (dij.Vnev.Contains("Curie"))
                {
                    Console.WriteLine($"\t{dij.Ev}: {dij.Knev} {dij.Vnev}({dij.Tipus})");
                }
            }
        }

        private static void Fealdat05()
        {
            Console.WriteLine($"5. Feladat:\t");
            foreach (Dij dij in dijjak)
            {
                if (dij.Vnev == "" && dij.Ev > 1990)
                {
                    Console.WriteLine($"\t{dij.Ev}: {dij.Knev}");
                }
            }
        }

        private static void Feladat04()
        {
            // ki kapott 2017 ben irodalmi nobel dijjat
            foreach (Dij dij in dijjak)
            {
                if (dij.Ev == 2017 && dij.Tipus == "irodalmi")
                {
                    Console.WriteLine($"4. Feladat: {dij.Knev} {dij.Vnev}");
                }
            }
        }

        private static void Feladat03()
        {
            foreach (Dij dij in dijjak)
            {
                if (dij.Knev == "Arthur B." && dij.Vnev == "McDonald")
                {
                    Console.WriteLine($"3. feladat: {dij.Tipus}");
                }
            }
        }

        private static void Beolvasas()
        {
            foreach (string dij in File.ReadAllLines("nobel.csv").Skip(1))
            {
                dijjak.Add(new Dij(dij));
            }
        }
    }
}
