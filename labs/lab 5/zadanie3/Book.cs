using System;
namespace lab5.zadanie3
{
    public class Book : IEntity<int>, IDataUtworzenia
    {
        public int Id { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public string Tytuł { get; set; }
        public string Autor { get; set; }
        public int Rok { get; set; }

        public Book(int id, string tytuł, string autor, int rok)
        {
            Id = id;
            Tytuł = tytuł;
            Autor = autor;
            Rok = rok;
            DataUtworzenia = DateTime.Now;
        }
    }

}

