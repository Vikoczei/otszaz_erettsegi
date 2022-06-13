using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace otszaz_erettsegi
{
    class Program
    {
        static void feladat_5(string arucikk, List<string> lista)
        {
            List<string> lista2 = new List<string>();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == arucikk)
                {
                    lista2.Add(arucikk);
                }
            }
        }


        static void Main(string[] args)
        {
            List<List<string>> kosarak = new List<List<string>>();

            using (StreamReader f = new StreamReader("penztar.txt", Encoding.Default))
            {
                while (!f.EndOfStream)
                {
                    List<string> aktualis_kosar = new List<string>();
                    string sor = f.ReadLine();
                    while (sor != "F")
                    {
                        aktualis_kosar.Add(sor);
                        sor = f.ReadLine();
                    }
                    kosarak.Add(aktualis_kosar);
                }
            }

            Console.WriteLine("2. feladat");
            Console.WriteLine($"A fizetések száma: {kosarak.Count}");

            Console.WriteLine("3. feladat");
            Console.WriteLine($"Az első vásárló {kosarak[0].Count} db árucikket vásárolt");
            /*
            Console.WriteLine("5B:");
            string megadott_árucikk = Console.ReadLine();
            

            int kosar_sum = 0;
            foreach (List<string> kosár in kosarak)
            {
                foreach (string árucikk in kosár)
                {
                    if (árucikk == megadott_árucikk)
                    {
                        kosar_sum++;
                    }
                }
            }
            Console.WriteLine("ennyit vettek: ");
            Console.WriteLine(kosar_sum);
            */

            Console.WriteLine("Adja meg egy vásárlás sorszámát!");
            int sorszam = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg egy árucikk nevét!");
            string arucikk = Console.ReadLine();
            Console.WriteLine("Adja meg a vásárolt darabszámot!");
            int db = int.Parse(Console.ReadLine());
            


            Console.ReadKey();
        }
    }
}
