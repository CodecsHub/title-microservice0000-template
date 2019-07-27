using Dapper;
using Microservice00001TemplateAPI.DataAccessLayers;
using Microservice00001TemplateAPI.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice00001TemplateAPI.Repositories
{
    public class UtilitySqlDataAccess : ISqlDataAccess
    {

        public IOptions<UtilityAppSettings> _appSettings;

        // DI name must base on the class name

        public UtilitySqlDataAccess(IOptions<UtilityAppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        public async void InsertData<T>(T model, string sql)
        {
            using (IDbConnection cnn = LoadConnectionString())
            {
                await cnn.ExecuteAsync(sql, model);
             
               // return output.ToString();
            }
        }
        // public async Task<List<V1Activity>> Get()
        //public async List<T> LoadData<T>(string sql)
        public  List<T> LoadData<T>(string sql)
        {
            throw new NotImplementedException();
        }

        public void UpdateData<T>(T model, string sql)
        {
            
        }

        private IDbConnection LoadConnectionString(string connectionName = "DatabaseConnectionRead")
        {

                return new SqlConnection(connectionName);

        }
    }
}
