using System;
using lab5.zadanie3;
namespace lab5.zadanie3
{
    public class Book : IEntity<int>, IDataUtworzenia
    {
        public int Id { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public string Tytuł { get; set; }
        public string Autor { get; set; }
        public int Rok { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }

}

