namespace PharmacyManager.Data.Dependency
{
    using PharmacyManager.Data.Context;
    using PharmacyManager.Data.Repositories.Interfaces;
    using PharmacyManager.Data.Repositories.Realization;
    using StructureMap;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
            For<IMedicamentRepository>().Use<MedicamentRepository>();
            For<IUserRepository>().Use<UserRepository>();
        }
    }
}
