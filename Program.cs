using ObliczanieDatySprzedaży.Class;
using System;

namespace ObliczanieDatySprzedaży

{
    class Program
    {
        static void Main(string[] args)
        {
            var obliczanie = new Obliczanie();
            var pytanie = new Pytania();
            var stado = new Stado();

            bool dzieńRoboczy;
            bool dzieńUbojowy;

            Console.WriteLine($"Wprowadź datę wstawienia: ");
            stado.dataWstawienia = DateTime.Parse(Console.ReadLine());

            do
            {


                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();

                // Pierwsza część - obliczanie dat zdarzeń stada

                dzieńRoboczy = drukujWstawienie(obliczanie, stado);
                dzieńRoboczy = drukujPrzerzut(obliczanie, stado);
                drukujFaktura(obliczanie, stado);

                // Druga część - obliczanie i wyświetlenie dat sprzedaży

                drukujNagłówek("indyczki", $"{stado.dzieńSprzedażyIndyczkiOd}-{stado.dzieńSprzedażyIndyczkiDo} :");
                dzieńUbojowy = WyliczenieDatySprzedaży("indyczka", obliczanie, stado);

                drukujNagłówek($"przebiórki", $"{stado.dzieńSprzedażyPrzebiórkiOd}-{stado.DzieńSprzedażyPrzebiórkiDo}");
                dzieńUbojowy = WyliczenieDatySprzedaży("przebiórka", obliczanie, stado);

                drukujNagłówek("indora", $"{stado.dzieńSprzedażyIndoraOd}-{stado.dzieńSprzedażyIndoraDo}");
                dzieńUbojowy = WyliczenieDatySprzedaży("indor", obliczanie, stado);

                do
                {
                    Console.WriteLine();
                    Console.Write("\tCzy chcesz porwawić dane? (t/n) ");
                    string input = Console.ReadLine();

                    if (input == "t")
                    {
                        break;
                    }

                    if (input == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tOk. Program zakończył działanie");
                        Environment.Exit(0);
                    }

                    else if ((input != "t") || (input != "n"))
                    {
                        Console.WriteLine("\tWciśnij T dla tak lub N dla nie");
                    }

                } while (true);


                Console.Clear();
                Console.Write("\tObecnie ustawienia : ");

                drukujNagłówek("indyczki", $"{stado.dzieńSprzedażyIndyczkiOd}-{stado.dzieńSprzedażyIndyczkiDo} :");
                dzieńUbojowy = WyliczenieDatySprzedaży("indyczka", obliczanie, stado);

                do
                {
                    Console.WriteLine();
                    Console.Write("\tCzy chcesz poprawić dane w indyczce?  t/n  ");
                    string input = Console.ReadLine();

                    if (input == "t")
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tPodaj nowe dni sprzedaży :");
                        Console.Write("\tDzień sprzedaży od : ");
                        stado.dzieńSprzedażyIndyczkiOd = int.Parse(Console.ReadLine());
                        Console.Write("\tDzień sprzedaży do : ");
                        stado.dzieńSprzedażyIndyczkiDo = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.Write("\tObecnie ustawienia : ");

                        drukujNagłówek("indyczki", $"{stado.dzieńSprzedażyIndyczkiOd}-{stado.dzieńSprzedażyIndyczkiDo} :");
                        dzieńUbojowy = WyliczenieDatySprzedaży("indyczka", obliczanie, stado);

                        continue;
                    }

                    if (input == "n")
                    {
                        break;
                    }

                    else if ((input != "t") || (input != "n"))
                    {
                        Console.WriteLine("\tWciśnij T dla tak lub N dla nie");
                    }

                } while (true);

                Console.Clear();
                Console.Write("\tObecnie ustawienia przebiórki: ");

                drukujNagłówek($"przebiórki", $"{stado.dzieńSprzedażyPrzebiórkiOd}-{stado.DzieńSprzedażyPrzebiórkiDo}");
                dzieńUbojowy = WyliczenieDatySprzedaży("przebiórka", obliczanie, stado);

                do
                {
                    Console.WriteLine();
                    Console.Write("\tCzy chcesz poprawić dni sprzedaży przebiórki? t/n ");
                    string input = Console.ReadLine();

                    if (input == "t")
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tPodaj nowe dni sprzedaży przebiórki :");

                        Console.Write("\tDzień sprzedaży od : ");
                        stado.dzieńSprzedażyPrzebiórkiOd = int.Parse(Console.ReadLine());
                        Console.Write("\tDzień sprzedaży do : ");
                        stado.DzieńSprzedażyPrzebiórkiDo = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("\tAktualne ustawienia :");
                        drukujNagłówek($"przebiórki", $"{stado.dzieńSprzedażyPrzebiórkiOd}-{stado.DzieńSprzedażyPrzebiórkiDo}");
                        dzieńUbojowy = WyliczenieDatySprzedaży("przebiórka", obliczanie, stado);

                        continue;
                    }

                    else if (input == "n")
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("\tWciśnij T dla tak lub N dla nie");
                    }

                } while (true);


                do
                {
                    Console.Clear();
                    Console.WriteLine("\tAktualne ustawienia indora:");
                    drukujNagłówek($"indor", $"{stado.dzieńSprzedażyIndoraOd}-{stado.dzieńSprzedażyIndoraDo}");
                    dzieńUbojowy = WyliczenieDatySprzedaży("indor", obliczanie, stado);

                    Console.WriteLine();
                    Console.Write("\tCzy chcesz poprawić dane w indorze ?  t/n  ");
                    string input = Console.ReadLine();

                    if (input == "t")
                    {
                        Console.WriteLine("\tPodaj nowe dni sprzedaży :");
                        Console.Write("\tDzień sprzedaży od : ");
                        stado.dzieńSprzedażyIndoraOd = int.Parse(Console.ReadLine());
                        Console.Write("\tDzień sprzedaży do : ");
                        stado.dzieńSprzedażyIndoraDo = int.Parse(Console.ReadLine());

                        continue;
                    }

                    else if (input == "n")
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("\tWciśnij T dla tak lub N dla nie");
                    }

                } while (true);

            }
            while (true);

        }


        // Metody lokalne

        private static void drukujFaktura(Obliczanie obliczanie, Stado stado)
        {
            stado.dataWystawieniaFaktury = stado.dataWstawienia.AddDays(43);
            Console.Write($"\tFaktura:\t{stado.dataWystawieniaFaktury: dddd d MMMM yyyy}");
            obliczanie.wyświetlCzyDzieńRoboczy(obliczanie.sprawdżCzyDzieńRoboczy(stado.dataWystawieniaFaktury));
        }

        private static bool drukujPrzerzut(Obliczanie obliczanie, Stado stado)
        {
            bool dzieńRoboczy;
            stado.dataPrzerzutu = stado.dataWstawienia.AddDays(28);
            Console.Write($"\tPrzerzut:\t{stado.dataPrzerzutu: dddd d MMMM yyyy}");
            dzieńRoboczy = obliczanie.sprawdżCzyDzieńRoboczy(stado.dataPrzerzutu);
            obliczanie.wyświetlCzyDzieńRoboczy(dzieńRoboczy);
            return dzieńRoboczy;
        }

        private static bool drukujWstawienie(Obliczanie obliczanie, Stado stado)
        {
            bool dzieńRoboczy = obliczanie.sprawdżCzyDzieńRoboczy(stado.dataWstawienia);
            Console.Write($"\tWstawienie:\t{stado.dataWstawienia: dddd d MMMM yyyy}");
            obliczanie.wyświetlCzyDzieńRoboczy(dzieńRoboczy);
            return dzieńRoboczy;
        }

        private static void drukujNagłówek(string rodzajPtaka, string wiek)
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\tSprzedaż {rodzajPtaka} w wieku {wiek} dni:\n");
            Console.ResetColor();
        }

        private static bool WyliczenieDatySprzedaży(string rodzaj, Obliczanie obliczanie, Stado stado)
        {
            bool dzieńUbojowy;
            DateTime dataSprzedażyOd;
            DateTime dataSprzedażyDo;

            switch(rodzaj)
            {
                case "indyczka":
                    dataSprzedażyOd = stado.dataWstawienia.AddDays(stado.dzieńSprzedażyIndyczkiOd);
                    dataSprzedażyDo = stado.dataWstawienia.AddDays(stado.dzieńSprzedażyIndyczkiDo);
                    DrukujWyliczenia(obliczanie, dataSprzedażyOd, dataSprzedażyDo);

                    break;

                case "przebiórka":
                    dataSprzedażyOd = stado.dataWstawienia.AddDays(stado.dzieńSprzedażyPrzebiórkiOd);
                    dataSprzedażyDo = stado.dataWstawienia.AddDays(stado.DzieńSprzedażyPrzebiórkiDo);
                    DrukujWyliczenia(obliczanie, dataSprzedażyOd, dataSprzedażyDo);

                    break;

                case "indor":
                    dataSprzedażyOd = stado.dataWstawienia.AddDays(stado.dzieńSprzedażyIndoraOd);
                    dataSprzedażyDo = stado.dataWstawienia.AddDays(stado.dzieńSprzedażyIndoraDo);
                    DrukujWyliczenia(obliczanie, dataSprzedażyOd, dataSprzedażyDo);

                    break;

                default:
                    Console.WriteLine("Błędna wartość rodzaj ptaka");
                    break;
            }
            return true;
        }

        private static bool DrukujWyliczenia(Obliczanie obliczanie, DateTime dataSprzedażyOd, DateTime dataSprzedażyDo)
        {
            bool dzieńUbojowy;
            Console.Write($"\tod:\t{dataSprzedażyOd: dddd d MMMM yyyy}");
            dzieńUbojowy = obliczanie.sprawdźCzyDzieńUbojowy(dataSprzedażyOd);
            obliczanie.wyświetlCzyDzieńUbojowy(dzieńUbojowy);

            Console.Write($"\tod:\t{dataSprzedażyDo: dddd d MMMM yyyy}");
            dzieńUbojowy = obliczanie.sprawdźCzyDzieńUbojowy(dataSprzedażyDo);
            obliczanie.wyświetlCzyDzieńUbojowy(dzieńUbojowy);
            return dzieńUbojowy;
        }
    }
}