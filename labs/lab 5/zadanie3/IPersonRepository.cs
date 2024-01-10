namespace lab5.zadanie3
{
    public interface IPersonRepository<T, TEntity> : IBaseRepository<T, TEntity> where TEntity : IEntity<T>
    {
        List<Book> Getbooks(Person person);
        void DodajKsiązkeDoListy(Person person, Book book);
    }
}