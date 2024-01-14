namespace lab5.zadanie3
{
    public interface IPersonRepository : IBaseRepository<Person, int>
    {
        List<Book> GetBorrowedBooks(int id);
        void BorrowBook(int id, int bookId);
    }
}