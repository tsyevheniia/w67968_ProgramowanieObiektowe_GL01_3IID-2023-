using lab5.zadanie2;
namespace lab5.zadanie1
{
	public class Program
	{
		static void Main()
		{
            // ===============================
            //Console.WriteLine("Zadanie 1:");
            //Circle circle = new Circle(7);
            //circle.CalulateArea();

            //Square square = new Square(7);
            //square.CalulateArea();

            // ===============================
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
        }
    }
}


