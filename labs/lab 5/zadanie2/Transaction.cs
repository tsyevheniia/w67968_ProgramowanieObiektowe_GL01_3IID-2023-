
namespace lab5.zadanie2
{
	public abstract class Transaction
	{
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public abstract void ProcessTransaction();
    }
}

