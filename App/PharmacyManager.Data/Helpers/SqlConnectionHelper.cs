namespace PharmacyManager.Data.Helpers
{
    using System.Data.SqlClient;

    internal class SqlConnectionHelper
    {
        internal string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "";
            builder.InitialCatalog = "pm_dev";

            return builder.ToString();
        }
    }
}
