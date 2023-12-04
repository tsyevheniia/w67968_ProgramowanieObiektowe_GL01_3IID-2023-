using lab2classlibrary.Models;
class Program
{
    static void Main()
    {
        Console.WriteLine("----Zadabie 1:----");
        Licz liczba = new Licz(7);
        liczba.Dodaj(2);
        liczba.Odejmi(1);
        liczba.DisplayValue();
        Console.WriteLine();

        Console.WriteLine("----Zadanie 2:----");
        int[] liczby = { 1, 2, 3, 4 };
        Sumator sumator = new Sumator(liczby);
        sumator.Suma();
        sumator.SumaPodziel3();
        sumator.IleElementow();
        sumator.ElementyTablicy();
        Console.WriteLine();

        Console.WriteLine("----Zadanie 3:----");
        Samochód samochod = new Samochód("BMW", "X5", 2012);
        samochod.UruchomienieSilnika();
        samochod.UstawTempomat(70);
        samochod.ZmniejszaniePrędkości();
        samochod.ZwięszeniePrędkości();
        samochod.Przejazd(250);
        samochod.ZatrzymaniePracySilnika();
        Console.WriteLine();

        Console.WriteLine("----Zadanie 4:----");
        Osoba osoba = new Osoba("Olha", "Janowska", 18, "19.01.2005", "Kobieta", "5647854");
        osoba.Pelnoletność();
        osoba.ZmianaNazwiska();
        osoba.UstawSamochód(samochod);
        osoba.InformacjaOSamochodzie();

        









    }
}