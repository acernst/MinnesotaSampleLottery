using System.Configuration;

namespace MinnesotaSampleLottery.DAL
{
    /// <summary>
    /// Returns the connection string for the application
    /// </summary>
    public static class AppConfiguration
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            }
        }
        /// <summary>
        /// Returns the name of the current connections string for the application
        /// </summary>
        public static string ConnectionStringName
        {
            get
            {
                return ConfigurationManager.AppSettings["ConnectionStringName"];
            }
        }
    }
}
