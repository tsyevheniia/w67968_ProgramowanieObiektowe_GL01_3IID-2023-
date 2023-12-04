using System;
using System.Diagnostics;
using static lab2classlibrary.Models.Samochód;

namespace lab2classlibrary.Models
{
    public class Licz
    {
        private int Value;
        public Licz(int value)
        {
            Value = value;
        }
        public void Dodaj(int addvalue)
        {
            Value += addvalue;
        }
        public void Odejmi(int minusvalue)
        {
            Value -= minusvalue;
        }
        public void DisplayValue()
        {
            Console.WriteLine("Current Value: " + Value);
        }
    }
    public class Sumator
    {
        private int[] Liczby;
        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }
        public void Suma()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                suma += liczba;
            }
            Console.WriteLine(suma);
        }
        public void SumaPodziel3()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                if (liczba % 3 == 0)
                {
                    suma += liczba;
                }
            }
            Console.WriteLine( suma);
        }
        public void IleElementow()
        {
            Console.WriteLine(Liczby.Length);
        }
        public void ElementyTablicy()
        {
            foreach (int liczba in Liczby)
            {
                Console.WriteLine("Element: " + liczba);
            }
        }
        public void GetElements(int lowIndex, int highIndex)
        {

            for (int i = lowIndex; i <= highIndex && i < Liczby.Length; i++)
            {
                Console.WriteLine("Element: " + Liczby[i]);
            }

        }

    }
    public class Samochód
    {
        public string Marka;
        public string Model;
        public int Rok_produkcji;
        private int Predkość;
        private int Przebieg;
        private StanSilnika Stan_silnika;

        public enum StanSilnika
        {
            Uruchomiony,
            Wyłączony,
            CheckEngine
        }

        public Samochód(string marka, string model, int rokprodukcji)
        {
            Marka = marka;
            Model = model;
            Rok_produkcji = rokprodukcji;
            Predkość = 0;
            Przebieg = 0;
            Stan_silnika = StanSilnika.Wyłączony;
        }

        public int Prędkość => Predkość;

        public double Przejazd(int dystans)
        {
            if (Stan_silnika == StanSilnika.Uruchomiony)
            {
                Console.WriteLine($"Samochód porusza się i pokonuje dystans {dystans} km.");
                Przebieg += dystans;

                if (Przebieg >= 10000)
                {
                    Stan_silnika = StanSilnika.CheckEngine;
                    Console.WriteLine("Check Engine! Stan silnika zmieniono na Check Engine.");
                    throw new Exception("Check Engine! Nie można kontynuować jazdy.");
                }

                double czas = dystans / (double)Prędkość;
                Console.WriteLine($"Samochód porusza się i pokonuje odległość {dystans} km w ciągu {Math.Round(czas, 2)} godzin");
                return czas;
            }
            else
            {
                Console.WriteLine("Silnik jest wyłączony. Nie można kontynuować jazdy.");
                return 0;
            }
        }

        public void UstawTempomat(int ustalonaPrędkość)
        {
            Predkość = ustalonaPrędkość;
            Console.WriteLine($"Tempomat ustawiony na prędkość {Prędkość} km/h.");
        }

        public void ZwięszeniePrędkości()
        {
            if (Stan_silnika == StanSilnika.Uruchomiony)
            {
                Predkość += 5;
                Console.WriteLine($"Zwiększanie prędkości o 5, prędkość równa się {Prędkość}");
            }
            else
            {
                Console.WriteLine("Nie można zwiększyć prędkości, gdy silnik jest wyłączony.");
            }
        }

        public void ZmniejszaniePrędkości()
        {
            if (Stan_silnika == StanSilnika.Uruchomiony)
            {
                Predkość -= 5;
                Console.WriteLine($"Zmniejszanie prędkości o 5, prędkość równa się {Prędkość}");
            }
            else
            {
                Console.WriteLine("Nie można zmniejszyć prędkości, gdy silnik jest wyłączony.");
            }
        }

        public void UruchomienieSilnika()
        {
            if (Przebieg >= 10000)
            {

                throw new Exception("Check Engine! Przebieg przekroczył 10000 km.");
            }

            if (Stan_silnika == StanSilnika.Wyłączony)
            {
                Stan_silnika = StanSilnika.Uruchomiony;
                Console.WriteLine("Uruchomienie silnika");
            }
        }

        public void ZatrzymaniePracySilnika()
        {
            Stan_silnika = StanSilnika.Wyłączony;
            Console.WriteLine("Zatrzymanie pracy silnika");
        }
       
    }
    public class Osoba
    {
        private string Imię;
        private string Nazwisko;
        private int Wiek;
        private string Data_urodzenia;
        private string Płeć;
        private string Numer_telefonu;

        private Samochód samochód;

        public string ImięINazwisko => $"{Imię} {Nazwisko}";

        public Osoba(string imię, string nazwisko, int wiek, string data_urodzenia, string plec, string numer_telefonu)
        {
            Imię = imię;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Data_urodzenia = data_urodzenia;
            Płeć = plec;
            Numer_telefonu = numer_telefonu;
        }
        public void Pelnoletność()
        {
            if (Wiek >= 18)
            {
                Console.WriteLine("Osoba jest pelnoletnia");
            }
            else
            {
                Console.WriteLine("Osoba nie jest pelnoletnia");
            }
        }
        public void ZmianaNazwiska()
        {
            Console.WriteLine("Podaj nowę nazwisko:");
            Nazwisko = Console.ReadLine();
            Console.WriteLine($"Osoba nazywa się: {ImięINazwisko}");
        }
        public void UstawSamochód(Samochód nowySamochód)
        {
            samochód = nowySamochód;
            Console.WriteLine($"{ImięINazwisko} ma prawo własności na {samochód.Marka} {samochód.Model}");
        }
        public void InformacjaOSamochodzie()
        {
            if (samochód == null)
            {
                Console.WriteLine("Osoba nie posiada samochodu");
            }
            else
            {
              
                Console.WriteLine($"{ImięINazwisko} ma samochód, informacja o nim:{samochód.Marka}, {samochód.Model}, {samochód.Rok_produkcji}");
            }
        }
    }
}



