
namespace lab5.zadanie2
{
	public class ExpenseTransaction : Transaction
	{
        public ExpenseTransaction(double amount)
        {
            Amount = amount;
        }
        public override void ProcessTransaction()
        {
            Account.Wydatki -= Amount;
            Console.WriteLine($"Expense Transaction Processed: -{Amount}");
        }
    }
}

