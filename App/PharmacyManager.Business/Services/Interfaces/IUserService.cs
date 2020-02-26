using PharmacyManager.Shared.Entities;

namespace PharmacyManager.Business.Services.Interfaces
{
    public interface IUserService : IService<User>
    {
        User GetByCredentials(string login, string password);
    }
}
