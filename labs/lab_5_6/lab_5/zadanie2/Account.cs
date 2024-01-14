namespace lab5.zadanie2
{
	public class Account 
	{
		public List<Transaction> transactions { get; }
        public static double Przychody { get; set; }
		public static double Wydatki { get; set; }

        public Account()
        {
            transactions = new List<Transaction>(); // []
        }

        public void DodajTransakcje(Transaction transaction)
        {
            transactions.Add(transaction);
        }
    }
}

