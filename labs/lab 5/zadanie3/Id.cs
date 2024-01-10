namespace lab5.zadanie3;
public interface IEntity<T>
{
    T Id { get; set; }
}

public interface IDataUtworzenia
{
    DateTime DataUtworzenia { get; set; }
}