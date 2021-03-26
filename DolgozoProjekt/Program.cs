using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DolgozoProjekt
{
    class Program
    {
        private static List<Dolgozo> dolgozok;

        static void Main(string[] args)
        {
            beolvas();
            //kiir();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();

            Console.ReadKey();
        }

        private static void feladat8()
        {
            using (StreamWriter sw = new StreamWriter("diakok.txt", true))
            {
                foreach (var dolgozo in dolgozok)
                {
                    if (dolgozo.Eletkor < 18)
                    {
                        sw.WriteLine($"{dolgozo.Vezeteknev} {dolgozo.Keresztnev} {dolgozo.Nem} {dolgozo.Eletkor} {dolgozo.Fizetes} {dolgozo.Ft}");
                    }
                }
            }
        }

        private static void feladat7()
        {
            Console.WriteLine($"7. Feladat: ");
        }

        private static void feladat6()
        {
            int Szam;
            Console.Write($"6. feladat:  Kérem adjon meg egy összeget: ");
            bool szamE = int.TryParse(Console.ReadLine(), out Szam);

            while (!szamE)
            {
                Console.Write("Nem számot adott meg. Kérem adjon meg egy összeget: ");
                szamE = int.TryParse(Console.ReadLine(), out Szam);
            }

            foreach (var dolgozo in dolgozok)
            {
                if (dolgozo.Fizetes > Szam)
                {
                    Console.WriteLine($"Van olyan dolgozó, akinek a fizetes {Szam} Ft felett van");
                    break;
                }
            }
        }

        private static void feladat5()
        {
            int legnagyobbFizetes = dolgozok[0].Fizetes;
            int index = 0;

            for (int i = 0; i < dolgozok.Count; i++)
            {
                if (legnagyobbFizetes < dolgozok[i].Fizetes)
                {
                    legnagyobbFizetes = dolgozok[i].Fizetes;
                    index = i;
                }
            }

            Console.WriteLine($"Legnagyobb fizetésű dolgozó adatai: " +
                $"\n\tA dolgozó neve: {dolgozok[index].Vezeteknev} {dolgozok[index].Keresztnev}" +
                $"\n\tNeme: {dolgozok[index].Nem}" +
                $"\n\tÉletkora: {dolgozok[index].Eletkor}" +
                $"\n\tFizetése: {dolgozok[index].Fizetes} {dolgozok[index].Ft}");
        }

        private static void feladat4()
        {
            int osszFizetes = 0;

            foreach (var dolgozo in dolgozok)
            {
                if (dolgozo.Eletkor < 25)
                {
                    osszFizetes += dolgozo.Fizetes;
                }
            }

            Console.WriteLine($"4. feladat: 25 év alattiak összfizetése: {osszFizetes} Ft");
        }

        private static void feladat3()
        {
            Console.WriteLine($"3. feladat: Dolgozók száma: {dolgozok.Count}");
        }

        private static void kiir()
        {
            foreach (var dolgozo in dolgozok)
            {
                Console.WriteLine(dolgozo);
            }

        }

        private static void beolvas()
        {
            dolgozok = new List<Dolgozo>();
            using (StreamReader sr = new StreamReader("adatok.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(' ');
                    string vezeteknev = sor[0];
                    string keresztnev = sor[1];
                    string nem = sor[2];
                    int eletkor = int.Parse(sor[3]);
                    int fizetés = int.Parse(sor[4]);
                    string ft = sor[5];

                    Dolgozo dolgozo = new Dolgozo(vezeteknev, keresztnev, nem, eletkor, fizetés, ft);
                    dolgozok.Add(dolgozo);
                }
            }
        }


    }
}
