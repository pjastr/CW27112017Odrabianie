using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok");
            int rok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj miesiac");
            int miesiac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj dzien");
            int dzien = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj godzine");
            //int godz = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj minuty");
            //int min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj sekundy");
            //int sek = Convert.ToInt32(Console.ReadLine());
            DateTime pora = new DateTime( rok, miesiac,dzien);

            Console.WriteLine(pora.ToString());
            Console.ReadKey();
        }
    }
}
