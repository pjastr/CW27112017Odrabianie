using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj date w formacie: Thu 16 Nov 8:30 AM 2017");
            string wejscie = Console.ReadLine();
            string format = "ddd dd MMM h:mm tt yyyy";
            DateTime dateTime;
            DateTime.TryParseExact(wejscie, format, CultureInfo.InvariantCulture,
            DateTimeStyles.None, out dateTime);
            Console.WriteLine(dateTime);
            Console.ReadKey();
        }
    }
}
