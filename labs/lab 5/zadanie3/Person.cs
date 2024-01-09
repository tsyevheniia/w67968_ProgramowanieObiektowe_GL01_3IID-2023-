using System;
namespace lab5.zadanie3
{
    public class Person : IEntity<int>, IDataUtworzenia
    {
        public int Id { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public List<Book> lista_wypożyczonych_książek { get; set; } = new List<Book>();

        public Person(int id, string imię, string nazwisko, int wiek)
        {
            Id = id;
            Imię = imię;
            Nazwisko = nazwisko;
            Wiek = wiek;
            DataUtworzenia = DateTime.Now;
        }
    }
   
}


