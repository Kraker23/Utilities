using System.Data.EntityClient;
using System.Data.SqlClient;


namespace Utilities.EntityManager
{
    public class ConexionManager
    {
        /// <summary>
        /// Server adress 
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        public string DataBase { get; set; }

        /// <summary>
        /// Conexion user
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Conexion user pasword
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Provider name. (Database type)
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IntegratedSecurity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool PersistSecurityInfo { get; set; }

        
        /// <summary>
        /// Name of EntityDataModel
        /// </summary>
        public string EntityDataModel { get; set; }


        /// <summary>
        /// Create a conexion string for EntityModel
        /// </summary>
        /// <returns>Conexion string</returns>
        public string CreateConexionString()
        {
            // Initialize the connection string builder for the 
            // underlying provider.
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            // Set the properties for the data source.
            sqlBuilder.DataSource = Server;
            sqlBuilder.InitialCatalog = DataBase;
            sqlBuilder.IntegratedSecurity = IntegratedSecurity;
            sqlBuilder.UserID = User;
            sqlBuilder.Password = Password;
            sqlBuilder.PersistSecurityInfo = PersistSecurityInfo;

            // Build the SqlConnection connection string. 
            string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = ProviderName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.
            entityBuilder.Metadata = string.Format(@"res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl", EntityDataModel);

            // create Entity
            return entityBuilder.ToString();
        }
    }
}
