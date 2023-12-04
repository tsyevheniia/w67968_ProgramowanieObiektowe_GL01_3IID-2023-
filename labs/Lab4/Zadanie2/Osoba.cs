namespace lab4_zad2
{
    public abstract class Osoba
    {
        public string Imię;
        public string Nazwisko;
        public string Pesel;

        public void SetFirstName(string imie)
        {
            Imię = imie;
        }
        public void SetLastName(string nazwisko)
        {
            Nazwisko = nazwisko;
        }
        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }
        public int GetAge()
        {
            return (DateTime.Now - PeselHelper.GetBirthDay(Pesel)).Days / 365;
        }

        public string GetGender()
        {
            var gender = int.Parse(Pesel.Substring(9, 2));
            if(gender % 2 == 0)
            {
                return "Kobieta";
            }
            else
            {
                return "Męzczyzna";
            }
        }
        
        public abstract string GetEducationInfo();
        public abstract string GetFullName();
        public abstract bool CanGoAloneToHome();

    }
    



}

