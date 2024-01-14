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
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }
}

