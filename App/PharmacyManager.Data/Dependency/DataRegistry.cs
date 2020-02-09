namespace PharmacyManager.Data.Dependency
{
    using PharmacyManager.Data.Repositories.Interfaces;
    using PharmacyManager.Data.Repositories.Realization;
    using StructureMap;

    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
            For<IMedicamentRepository>().Use<MedicamentRepository>();
            For<IUserRepository>().Use<UserRepository>();
        }
    }
}
