using PharmacyManager.IoC;
using PharmacyManager.UI.Dependency;
using StructureMap;
using System;
using System.Windows.Forms;

namespace PharmacyManager.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        private static IContainer GetContainer()
        {
            CustomContainer.Initialize();

            var container = CustomContainer.Container;
            container.Configure(c => c.AddRegistry<UIRegistry>());

            return container;
        }
    }
}
