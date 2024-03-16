﻿namespace EngLeash.Infrastructure.Persistence;
public interface IRepository<T> : IDisposable
        where T : class
{
    IEnumerable<T> GetElementsList();

    T GetElement(int id);

    void Create(T item);

    void Update(T item);

    void Delete(int id);

    void Save();
}