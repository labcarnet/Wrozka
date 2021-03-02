using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrozka
{
    class Program
    {
        static void Main(string[] args)
        {
            var error = "Nie oszukuj, Wprowadzone dane nie są prawdziwe. Wróżka wszystko wie!!!";

            Console.WriteLine("Witam w programie Wróżka.\n");
            Console.WriteLine("Jak masz na imię?");

            try
            {
                var name = Console.ReadLine();

                Console.WriteLine("Piękne Imię! Z którego rocznika jesteś?");

                var year = int.Parse(Console.ReadLine());

                Console.WriteLine("Jaki jest miesiąc Twoich urodzin?");

                var month = int.Parse(Console.ReadLine());

                Console.WriteLine("Jaki jest dzień Twoich urodzin?");

                var day = int.Parse(Console.ReadLine());

                Console.WriteLine("Powiedz mi jeszcze miejsce urodzenia a ja coś Ci wywróżę.");

                var city = Console.ReadLine();

                var age = Calculate(year, month, day);

                if(age > 0 && age < 110) Console.WriteLine($"\n Wynik wróżenia: \n Masz na imię: {name}, Pochodzisz z miejscowości {city}, Masz {age} lat na karku.");
                else Console.WriteLine(error);
            }
            catch (Exception)
            {
                Console.WriteLine(error);
            }
        }

        private static int Calculate(int year, int month, int day)
        {
            DateTime tuday = DateTime.Today;
            DateTime birthday = new DateTime(year, month, day);

            var currentDay = tuday.DayOfYear;
            var birthdayDay = birthday.DayOfYear;
            var age = tuday.Year - birthday.Year;

            if (currentDay < birthdayDay) age--;

            return age;
        }
    }
}
