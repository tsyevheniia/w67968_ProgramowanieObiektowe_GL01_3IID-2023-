using System;
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
        //for person repository

        var repository = new PersonRepository();
        var person1 = new Person { Id = 1, Imię = "John", Nazwisko = "Watson", Wiek = 25 };
        repository.Create(person1);


        Console.WriteLine("All persons:");
        foreach (var person in repository.GetAll())
        {
            Console.WriteLine($"{person.Imię} {person.Nazwisko}, Age: {person.Wiek}");
        }

        var updatedPerson = new Person { Id = 1, Imię = "John", Nazwisko = "Watson", Wiek = 26 };
        repository.Update(updatedPerson);

        Console.WriteLine("\nUpdated Information:");
        var newperson = repository.Get(1);
        Console.WriteLine($"{newperson.Imię} {newperson.Nazwisko}, Age: {newperson.Wiek}");


        var book1 = new Book { Id = 4, Tytuł = "The Catcher in the Rye", Autor = "J.D. Salinger", Rok = 1951 };
        repository.AddBook(book1);
        repository.BorrowBook(person1.Id, book1.Id);

        Console.WriteLine($"\nBorrowed books for {newperson.Imię} {newperson.Nazwisko}:");
        foreach (var book in repository.GetBorrowedBooks(person1.Id))
        {
            Console.WriteLine($"Title: {book.Tytuł}, Author: {book.Autor}, Year: {book.Rok}");
        }

        Console.WriteLine($"\nUpdated borrowed books for {newperson.Imię} {newperson.Nazwisko}:");
        foreach (var book in repository.GetBorrowedBooks(person1.Id))
        {
            Console.WriteLine($"Title: {book.Tytuł}, Author: {book.Autor}, Year: {book.Rok}");
        }

        // for book repository
        var repository1 = new BookRepository();
        var book2 = new Book { Id = 1, Tytuł = "The Catcher in the Rye", Autor = "J.D. Salinger", Rok = 1951 };
        repository1.Create(book2);
        

        Console.WriteLine(" ");
        Console.WriteLine("All books:");
        foreach (var book in repository1.GetAll())
        {
            Console.WriteLine($"Title: {book.Tytuł}, Author: {book.Autor}, Year: {book.Rok}");
        }

        Console.WriteLine("\nBooks by J.D. Salinger:");
        foreach (var book in repository1.GetBooksByAuthor("J.D. Salinger"))
        {
            Console.WriteLine($"Title: {book.Tytuł}, Author: {book.Autor}, Year: {book.Rok}");
        }


        Console.WriteLine("\nBooks published in 1951:");
        foreach (var book in repository1.GetBooksByYear(1951))
        {
            Console.WriteLine($"Title: {book.Tytuł}, Author: {book.Autor}, Year: {book.Rok}");
        }


        var updatedBook = new Book { Id = 1, Tytuł = "The Catcher in the Rye", Autor = "J.D. Salinger", Rok = 1951 };
        repository1.Update(updatedBook);


        Console.WriteLine("\nUpdated information for the first book:");
        var retrievedBook = repository1.Get(1);
        Console.WriteLine($"Title: {retrievedBook.Tytuł}, Author: {retrievedBook.Autor}, Year: {retrievedBook.Rok}");


        repository1.Delete(1);

        Console.WriteLine("\nAll books after deletion:");
        foreach (var book in repository1.GetAll())
        {
            Console.WriteLine($"Title: {book.Tytuł}, Author: {book.Autor}, Year: {book.Rok}");
        }
    }
}











