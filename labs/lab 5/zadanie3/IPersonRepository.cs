﻿namespace lab5.zadanie3
{
    public interface IPersonRepository<T, TEntity> : IBaseRepository<T, TEntity> where TEntity : IEntity<T>
    {
        
    }
}
