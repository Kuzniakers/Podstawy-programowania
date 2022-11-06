using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Komentarz xD
            //Console.WriteLine("Hello World!");

            //Console.WriteLine("Podaj nam swoje imie");
            //string name = Console.ReadLine();
            //string z = "ala ma kota";
            //Console.WriteLine(string.Format("Napisales : {0}, {1}", name, z));

           // Console.WriteLine("Podaj Liczbe");
           // string linia = Console.ReadLine(); 
           // double liczba;
           // double.TryParse(linia, out liczba);
           // Console.WriteLine(string.Format("Napisales {0}", liczba));

            
            double r;
            double wynik;
            

            Console.WriteLine("Oblicz objetość kuli, podaj promien kuli");
            r = Convert.ToInt32(Console.ReadLine());

            wynik = 4/3.0 * Math.PI * (r*r*r); 
            Console.WriteLine("Twoj wynik to" + " " + wynik);

            int x = 0;

            Console.WriteLine("");








            Console.ReadKey();

        }
    }
}
