namespace PharmacyManager.Business.Services.Interfaces
{
    public interface IService<T>
    {
        T GetById(int id);

        T GetAll();

        void Save(T obj);

        void Delete(int id);
    }
}
