using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            int number;

            Console.WriteLine("Podaj liczbę:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //zad1
            Console.WriteLine("Zad1:");
            Program.isEven(number);
            Console.WriteLine("\n");
            //zad2
            Console.WriteLine("Zad2:");
            Program.ShowEvenNumbers(number);
            Console.WriteLine("\n");
            //zad4
            Console.WriteLine("Zad4:");
            Program.Siłnia(number);
            Console.WriteLine("\n");
            //zad 5
            Console.WriteLine("Zad5: (Odgadaj liczbę (masz liczbę sprób):");
            Program.ŁosowaniaLiczb(number);
            Console.WriteLine("\n");
            //zad 6
            Console.WriteLine("Zad6: (Podaj liczbę do konvertowania):");
            Program.Converter(number);
            Console.WriteLine("\n");
            //zad3
            Console.WriteLine("Zad3:");
            Program.MenuSelection();
            Console.WriteLine("\n");
        }

        // Zadanie 1
        static void isEven(int n)
        {
            if ((n % 2) == 0)
            {
                Console.WriteLine("liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("liczba jest nieparzysta");
            };

        }
        // Zadanie 2
        static void ShowEvenNumbers(int n)
        {
            List<int> evenNumbers = new List<int>(n);

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
            }

            string result = string.Join(" ", evenNumbers);
            Console.WriteLine(result);
        }


        //Zadanie 4
        static void Siłnia(int n)
        {
            int liczba = 1;
            for (int i = 1; i <= n; i++)
            {
                liczba *= i;

            }
            Console.WriteLine(liczba);
        }

        // Zadanie 5
        static void ŁosowaniaLiczb(int n)
        {
            Random random = new Random();
            string randomNumber = random.Next(1, 10).ToString();
            string checkedNumber;

            Console.WriteLine("Sprobój odgadać liczbę od 1 do 9:");

            for (int i = 1; i <= n; i++)
            {
                checkedNumber = Console.ReadLine();

                if (checkedNumber == randomNumber)
                {
                    Console.WriteLine("Masz rację");
                    break;
                }
                else
                {
                    Console.WriteLine("Sprobój ponownie");
                }
            }
            Console.WriteLine($"Poprawna odpowiedź to: {randomNumber}");
        }

        // zadanie 6
        static void Converter(int n)
        {
            Console.WriteLine("Wybierz jednostki temperatury ((Celsiusz)c lub (Fahrenheit)f):");
            string temperatura = Console.ReadLine();

            if (temperatura == "c")
            {
                Console.WriteLine($"{n} stopni Celsjusza");
            }
            else if (temperatura == "f")
            {
                float fahrenheit = (n * 9.0f / 5.0f) + 32.0f;
                Console.WriteLine($"{n} stopni Celsjusza to {fahrenheit} stopni Fahrenheita");
            }
            Console.WriteLine("Wybierz jednostki długości ((Metry)m lub (Centymetry)c):");
            string długość = Console.ReadLine();
            if (długość == "c")
            {
                Console.WriteLine($"{n} Centrymetrów");
            }
            else if (długość == "m")
            {
                float metry = n / 100.0f;
                Console.WriteLine($"{n} centrymetrów to {metry} metrów");

            }

        }
        //Zadanie 3
        static void MenuSelection()
        {
            Console.WriteLine("Napisz liczbę od 1 do 6:");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Zad1:");
                    Program.isEven(n);
                    break;
                case 2:
                    Console.WriteLine("Zad2:");
                    Program.ShowEvenNumbers(n);
                    break;
                case 4:
                    Console.WriteLine("Zad4:");
                    Program.Siłnia(n);
                    break;
                case 5:
                    Console.WriteLine("Zad5: (Odgadaj liczbę (masz liczbę sprób):");
                    Program.ŁosowaniaLiczb(n);
                    break;
                case 6:
                    Console.WriteLine("Zad6: (Podaj liczbę do konvertowania):");
                    Program.Converter(n);
                    break;
                default:
                    Console.WriteLine("Nie ma takiej opcji!");
                    break;
            }

        }

    }
}