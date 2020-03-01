using System.Collections.Generic;

namespace PharmacyManager.Business.Services.Interfaces
{
    public interface IService<T>
    {
        T GetById(int id);

        IEnumerable<T> GetAll();

        void Save(T obj);

        void Delete(int id);

        void Delete(T obj);
    }
}
