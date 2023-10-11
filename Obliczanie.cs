using System;

namespace ObliczanieDatySprzedaży.Class

{
    public class Obliczanie
    {
        string dayOfWeek;

        public bool sprawdźCzyDzieńUbojowy(DateTime dataWstawienia)
        {
            dayOfWeek = dataWstawienia.DayOfWeek.ToString();

            if ((dayOfWeek == "Saturday") || (dayOfWeek == "Friday"))
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool sprawdżCzyDzieńRoboczy(DateTime dataWstawienia)
        {
            dayOfWeek = dataWstawienia.DayOfWeek.ToString();
                
            if ((dayOfWeek == "Saturday") || (dayOfWeek == "Sunday"))
            { 
                return false;
            }

            else
            {
                return true;
            }
        }

        public void wyświetlCzyDzieńRoboczy(bool czyDzieńRoboczy)
        {
            if (czyDzieńRoboczy == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t Ok (dzień roboczy)");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (czyDzieńRoboczy == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Błąd (dzień wolny)");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void wyświetlCzyDzieńUbojowy(bool czyDzieńUbojowy)
        {
            if (czyDzieńUbojowy == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t Ok (dzień ubojowy)");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (czyDzieńUbojowy == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Błąd (dzień nieubojowy)");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
