using System.Text;

namespace Pars2012
{
    internal class Program
    {
        static List<Versenyzo> Versenyzok = new();
        static void Main(string[] args)
        {
            Beolvas();
            Feladat5();
            Feladat6();
            Feladat9();
        }

        private static void Beolvas()
        {
            using StreamReader sr = new("@\\..\\..\\..\\..\\res\\Selejtezo2012.txt", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Versenyzok.Add(new(sr.ReadLine().Split(';')));
            }
        }
    
        private static void Feladat5()
        {
            Console.WriteLine($"5. feladat: Versenyzők száma a selejtezőben: {Versenyzok.Count} fő");
        }

        private static void Feladat6()
        {
            Console.Write("6. feladat: ");
            int tovabbjutott = 0;
            foreach (var x in Versenyzok)
            {
                if (x.D1 > 78 || x.D2 > 78) tovabbjutott++;
            }
            Console.WriteLine($"78,00 méter feletti eredménnyel továbbjutott: {tovabbjutott} fő");
        }

        private static void Feladat9()
        {
            Console.WriteLine("9. feladat: A selejtező nyertese:");
            int max = 0;
            for (int i = 0; i < Versenyzok.Count; i++)
            {
                if (Versenyzok[i].Eredmeny() > Versenyzok[max].Eredmeny()) max = i;
            }
            string d1 = Versenyzok[max].D1 == -2 ? "-" : Versenyzok[max].D1 == -1 ? "X" : Versenyzok[max].D1.ToString();
            string d2 = Versenyzok[max].D2 == -2 ? "-" : Versenyzok[max].D2 == -1 ? "X" : Versenyzok[max].D2.ToString();
            string d3 = Versenyzok[max].D3 == -2 ? "-" : Versenyzok[max].D3 == -1 ? "X" : Versenyzok[max].D3.ToString();
            Console.WriteLine("\tNév: " + Versenyzok[max].Nev +
                              "\n\tCsoport: " + Versenyzok[max].Csoport +
                              "\n\tNemzet: " + Versenyzok[max].Nemzet +
                              "\n\tNemzet kód: " + Versenyzok[max].Kod +
                             $"\n\tSorozat: {d1};{d2};{d3}" +
                              "\n\tEredmény: " + Versenyzok[max].Eredmeny());
        }

        private static void Feladat10()
        {
            using StreamWriter sw = new("Dontos2012.txt");
            List<Versenyzo> dontosok = new();

        }
    }
}