namespace PharmacyManager.Business.Dependency
{
    using PharmacyManager.Business.Services.Interfaces;
    using PharmacyManager.Business.Services.Realization;
    using StructureMap;

    public class BusinessRegistry : Registry
    {
        public BusinessRegistry()
        {
            For<IMedicamentService>().Use<MedicamentService>();
            For<IUserService>().Use<UserService>();
        }
    }
}
