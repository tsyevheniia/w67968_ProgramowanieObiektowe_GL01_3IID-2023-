namespace lab5.zadanie2
{
	public class IncomeTransaction : Transaction
	{
        public IncomeTransaction(double amount)
        {
            Amount = amount;
        }
        public override void ProcessTransaction()
        {
            Account.Przychody += Amount;
            Console.WriteLine($"Income Transaction Processed: +{Amount}");
        }
    }
}

