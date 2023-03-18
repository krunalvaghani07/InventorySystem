using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiComponents.Interfaces;
using System.Data.SqlClient;
using UiComponents.Data;
using Dapper;
using System.Collections;

namespace UiComponents.Repositories
{
    public class DataRepository: IDataRepository
    {
        #region Private Fields
        private string connectionString;

        #endregion Private Fields

        #region Public Constructors

        public DataRepository()
        {
            connectionString = "Server=tcp:krunalproduct.database.windows.net,1433;Initial Catalog=InventoryManagement;Persist Security Info=False;User ID=krunal;Password=krun@l2001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        #endregion Public Constructors
        public IDbConnection GetConnection
        {
            get
            {
                var list = DbProviderFactories.GetProviderInvariantNames();
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
        public async  Task<IEnumerable<Product>> GetProducts()
        {
            try
            {
                var query = Product.Select;
                var param = new DynamicParameters();
                return await SqlMapper.QueryAsync<Product>(this.GetConnection, query, param, commandType: CommandType.Text);
            }
           catch(Exception e)
            {
                throw e;
            }
        }
    }
}
