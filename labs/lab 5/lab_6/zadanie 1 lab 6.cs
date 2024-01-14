using static System.Reflection.Metadata.BlobBuilder;

namespace lab5.zadanie3
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> people = new List<Person>();
        private List<Book> books = new List<Book>();

        public void Create(Person item)
        {
            people.Add(item);
        }
        public void Update(Person item)
        {
            var existingPerson = people.FirstOrDefault(person => person.Id == item.Id);

            if (existingPerson != null)
            {
                existingPerson.Imię = item.Imię;
                existingPerson.Nazwisko = item.Nazwisko;
                existingPerson.Wiek = item.Wiek;
            }
        }

        public List<Person> GetAll()
        {
            return people;
        }
        public Person Get(int id)
        {
            return people.FirstOrDefault(person => person.Id == id);
        }
        public void Delete(int id)
        {
            var personToRemove = people.FirstOrDefault(person => person.Id == id);
            if (personToRemove != null)
            {
                people.Remove(personToRemove);
            }
        }

        public List<Book> GetBorrowedBooks(int id)
        {
            var person = people.FirstOrDefault(person => person.Id == id);
            return person?.BorrowedBooks ?? new List<Book>();
        }
        public void BorrowBook(int id, int bookId)
        {
            var person = people.FirstOrDefault(person => person.Id == id);
            var bookToBorrow = books.FirstOrDefault(book => book.Id == bookId);

            if (person != null && bookToBorrow != null)
            {
                person.BorrowedBooks.Add(bookToBorrow);
                books.Remove(bookToBorrow);
            }
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }


    }




    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();

        public void Create(Book item)
        {
            books.Add(item);
        }

        public void Update(Book item)
        {
            var existingBook = books.FirstOrDefault(book => book.Id == item.Id);

            if (existingBook != null)
            {
                existingBook.Tytuł = item.Tytuł;
                existingBook.Autor = item.Autor;
                existingBook.Rok = item.Rok;
            }
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public Book Get(int id)
        {
            return books.FirstOrDefault(book => book.Id == id);
        }

        public void Delete(int id)
        {
            var bookToRemove = books.FirstOrDefault(book => book.Id == id);
            if (bookToRemove != null)
                books.Remove(bookToRemove);
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return books.Where(book => book.Autor == author).ToList();
        }

        public List<Book> GetBooksByYear(int year)
        {
            return books.Where(book => book.Rok == year).ToList();
        }
    }
}




