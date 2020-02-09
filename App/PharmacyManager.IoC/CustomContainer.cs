namespace PharmacyManager.IoC
{
    using StructureMap;
    using StructureMap.Graph;

    public class CustomContainer
    {
        private static IContainer _container;

        public static void Initialize()
        {
            _container = new Container(
                x => x.Scan(
                           scan =>
                           {
                               AddBusinessDependency(scan);
                               AddDataDependency(scan);
                               scan.LookForRegistries();
                           }));
        }

        private static void AddBusinessDependency(IAssemblyScanner scan)
        {
        }

        private static void AddDataDependency(IAssemblyScanner scan)
        {
        }

        public static IContainer Container => _container;
    }
}