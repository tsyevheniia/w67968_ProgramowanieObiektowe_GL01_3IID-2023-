namespace lab5.zadanie3
{
    public class PersonRepository : IPersonRepository 
    {
        private List<Person> people = new List<Person>();

        public void Create(Person person)
        {
            people.Add(person);
        }

        public void Update(Person person)
        {
            var existingPerson = people.Find(p => p.Id == person.Id);
            if (existingPerson != null)
            {
                existingPerson.Imię = person.Imię;
                existingPerson.Nazwisko = person.Nazwisko;
                existingPerson.Wiek = person.Wiek;
            }
        }

        public List<Person> GetAll()
        {
            return people;
        }

        public Person Get(int id)
        {
            return people.Find(p => p.Id == id);
        }

        public void Delete(int id)
        {
            var person = people.Find(p => p.Id == id);
            if (person != null)
            {
                people.Remove(person);
            }
        }

        public List<Book> Getbooks(Person person)
        {
            return person.lista_wypożyczonych_książek;
        }

        public void DodajKsiązkeDoListy(Person person, Book book)
        {
            person.lista_wypożyczonych_książek.Add(book);
        }
    }

    public interface IPersonRepository
    {
    }

    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();

        public void Create(Book book)
        {
            books.Add(book);
        }

        public void Update(Book book)
        {
            var existingBook = books.Find(b => b.Id == book.Id);
            if (existingBook != null)
            {
                existingBook.Tytuł = book.Tytuł;
                existingBook.Autor = book.Autor;
                existingBook.Rok = book.Rok;
            }
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public Book Get(int id)
        {
            return books.Find(b => b.Id == id);
        }

        public void Delete(int id)
        {
            var book = books.Find(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        public List<Book> OtrzymajKsiazkeZaAutorem(string autor)
        {
            return books.Where(book => book.Autor == autor).ToList();
        }

        public List<Book> OtrzymajKsiazkeZaRokiem(int rok)
        {
            return books.Where(book => book.Rok == rok).ToList();
        }
    }

    public interface IBookRepository
    {
    }
}




