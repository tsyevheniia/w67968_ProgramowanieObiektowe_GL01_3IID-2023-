namespace lab5.zadanie3
{
    public interface IBookRepository<T, TEntity> : IBaseRepository<T, TEntity> where TEntity : IEntity<T>
    {

    }
}