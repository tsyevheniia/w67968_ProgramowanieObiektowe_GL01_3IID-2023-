using lab5.zadanie2;
using lab5.zadanie3;
namespace lab5.zadanie1;

public class Program
{
    static void Main()
    {

        Console.WriteLine("Zadanie 1:");
        Circle circle = new Circle(7);
        circle.CalulateArea();

        Square square = new Square(7);
        square.CalulateArea();


        Console.WriteLine("Zadanie 2:");
        Account account = new Account();

        IncomeTransaction transaction1 = new IncomeTransaction(500);
        transaction1.ProcessTransaction();
        ExpenseTransaction transaction2 = new ExpenseTransaction(20);
        transaction2.ProcessTransaction();

        account.DodajTransakcje(transaction1);
        account.DodajTransakcje(transaction2);

        foreach (Transaction transaction in account.transactions)
        {
            Console.WriteLine($"Amount:{transaction.Amount}");
        }

        Console.WriteLine(Account.Przychody);

        Console.WriteLine("Zadanie 3:");
        var personRepository = new PersonRepository();
        var bookRepository = new BookRepository();
        var book1 = new Book(1, "Pride and Prejudice", "Jane Austen", 1813);
        var person1 = new Person(1, "John", "Doe", 25);
        var person3 = new Person(2, "John", "Doe", 27);

        bookRepository.Create(book1);
        personRepository.Create(person1);
        personRepository.Create(person3);
        
        var updatedPerson = new Person(1, "Kristian", "Doe", 26);
        personRepository.Update(updatedPerson);

        var allBooks = bookRepository.GetAll();
        var allPeople = personRepository.GetAll();

        Console.WriteLine("All Books:");
        foreach (var book in allBooks)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Tytuł}, Author: {book.Autor}, Year: {book.Rok}");
        }

        Console.WriteLine("\nAll People:");
        foreach (var person in allPeople)
        {
            Console.WriteLine($"ID: {person.Id}, Name: {person.Imię} {person.Nazwisko}, Age: {person.Wiek}");
        }


        var bookToBorrow = new Book(3, "1984", "George Orwell", 1949);
        personRepository.DodajKsiązkeDoListy(person1, bookToBorrow);


        var borrowedBooks = personRepository.Getbooks(person1);

        Console.WriteLine("\nBooks Borrowed by John Doe:");
        foreach (var borrowedBook in borrowedBooks)
        {
            Console.WriteLine($"ID: {borrowedBook.Id}, Title: {borrowedBook.Tytuł}, Author: {borrowedBook.Autor}, Year: {borrowedBook.Rok}");
        }

        var booksByAuthor = bookRepository.OtrzymajKsiazkeZaAutorem("Jane Austen");

        Console.WriteLine("\nBooks by Jane Austen:");
        foreach (var book in booksByAuthor)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Tytuł}, Author: {book.Autor}, Year: {book.Rok}");
        }

        var booksByYear = bookRepository.OtrzymajKsiazkeZaRokiem(1813);

        Console.WriteLine("\nBooks published in 1813:");
        foreach (var book in booksByYear)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Tytuł}, Author: {book.Autor}, Year: {book.Rok}");
        }
    }
}







