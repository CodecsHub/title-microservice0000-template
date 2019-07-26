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
    public class V1ActivityRepositories : IV1ActivityRepositories
    {
        private readonly IOptions<UtilityAppSettings> _appSettings;

        // DI name must base on the class name
        public V1ActivityRepositories(IOptions<UtilityAppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        public async Task<List<V1Activity>> Get()
        {
            using (IDbConnection connection = new SqlConnection(_appSettings.Value.DatabaseConnectionRead))
            {
                string query = "EXEC V1Activity_GetAll";
                var output = await connection.QueryAsync<V1Activity>(query);
                return output.ToList();
            }
        }

        public Task<List<V1Activity>> Get(IIV1ActivityGetById model)
        {
            throw new NotImplementedException();
        }

        public Task<List<V1Activity>> Get(IIV1ActivityGetBySystemName model)
        {
            throw new NotImplementedException();
        }

        public Task<List<V1Activity>> Post(IIV1ActivityPost model)
        {
            throw new NotImplementedException();
        }
    }
}
