namespace lab5.zadanie3
{
    public interface IBookRepository : IBaseRepository<Book, int>
    {
        List<Book> GetBooksByAuthor(string autor);
        List<Book> GetBooksByYear(int rok);
    }
}