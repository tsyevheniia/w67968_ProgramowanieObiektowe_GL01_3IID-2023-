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
        Book book1 = new Book(1, "Pride and Prejudice", "Jane Austen", 1813);
        Book book2 = new Book(2,"1984", "George Orwell", 1949);
        Console.WriteLine(book1.Id);
        Person person = new Person(1,"Piotr", "Kar", 27);
        Console.WriteLine(person.Id);
    }
}


