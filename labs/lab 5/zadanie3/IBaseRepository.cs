namespace lab5.zadanie3
{
    public interface IBaseRepository<T, TEntity> where TEntity : IEntity<T>
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Get(T id);
        void Delete(T id);
    }

}
