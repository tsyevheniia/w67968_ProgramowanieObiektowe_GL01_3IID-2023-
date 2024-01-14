namespace lab4_zad2
{
    public class Uczeń : Osoba
    {
        public string Szkoła { get; set; }
        public bool MozeSamWracacDoDomu { get; set; }

        public void SetSchool(string szkola)
        {
            if (string.IsNullOrEmpty(Szkoła))
                Szkoła = szkola;
            else
                throw new Exception("Nie moge wstanowic szkolę");
        }

        public void ChangeSchool(string szkola)
        {
            Szkoła = szkola;
        }
        public void SetCanGoHomeAlone(bool mozesamwracacdodomu)
        {
            MozeSamWracacDoDomu = mozesamwracacdodomu;
        }
        public string Info()
        {
            if (GetAge() >= 12)
            {
                return "Moze sam wracac do domu";
            }
            else
            {
                return " Nie moze sam wracac do domu";
            }
        }

        public override string GetFullName()
        {
            return $"{Imię} {Nazwisko}";
        }

        public override bool CanGoAloneToHome()
        {
            return MozeSamWracacDoDomu || GetAge() >= 12;
        }

        public override string GetEducationInfo()
        {
            return Szkoła;
        }
    }
    
    


        

}

