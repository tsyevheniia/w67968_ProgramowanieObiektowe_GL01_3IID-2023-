namespace lab5.zadanie3
{
    public interface IBaseRepository<T, TEnitiy> where T : IEntity<TEnitiy>
    {
        
        void Create(T item);
        void Update(T item);
        void Delete(TEnitiy id);
        T Get(TEnitiy id);
        List<T> GetAll();
    }
}
