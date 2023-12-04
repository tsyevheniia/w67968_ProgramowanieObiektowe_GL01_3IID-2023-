
namespace lab4_zad2
{
    public class Nauczyciel : Uczeń
    {
        public string TytulNaukowy { get; set; }
        public List<Uczeń> Kolekcja_uczniów { get; set; } = new List<Uczeń>();
        public List<Uczeń> MogąWracacDoDomu { get; set; } = new List<Uczeń>();
        public void WhichStudentCanGoHomeAlone()
        {
            foreach (Uczeń uczen in Kolekcja_uczniów)
            {
                if (uczen.MozeSamWracacDoDomu)
                {
                    MogąWracacDoDomu.Add(uczen);
                }
            }
            foreach (Uczeń student in MogąWracacDoDomu)
            {
                Console.WriteLine(student.GetFullName());
            }

        }
        public override string GetFullName()
        {
            return $"{TytulNaukowy} {base.GetFullName()}";
        }
        public void ShowClass(DateTime date)
        {
            Console.WriteLine($"{Szkoła} Dnia: {date.DayOfWeek}");
            Console.WriteLine($"Nauczyciel: {TytulNaukowy} {Imię} {Nazwisko}  ");

            foreach (Uczeń uczen in Kolekcja_uczniów)
            {
                Console.WriteLine($"Lista studentów: {uczen.GetFullName()} {uczen.GetGender()} {uczen.CanGoAloneToHome()} {uczen.GetEducationInfo()}");
            }

        }

    }
}

