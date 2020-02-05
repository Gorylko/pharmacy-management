﻿namespace PharmacyManager.Data.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);

        T GetAll();

        void Save(T obj);

        void Delete(int id);
    }
}
