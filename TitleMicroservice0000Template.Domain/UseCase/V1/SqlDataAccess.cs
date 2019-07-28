using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TitleMicroservice0000Template.Domain.UseCase.V1
{
    class SqlDataAccess : ISqlDataAccess
    {
        public void DeleteData<T>(T model, string sql)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllData<T>(T model, string sql, string databaseConnection)
        {
            using (IDbConnection connectionString = new SqlConnection(databaseConnection))
            {
                var output = connectionString.Query<T>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        public List<T> GetDataBy<T>(T model, string sql)
        {
            throw new NotImplementedException();
        }

        public void InsertData<T>(T model, string sql, string databaseConnection)
        {
            using (IDbConnection connectionString = new SqlConnection(databaseConnection))
            {
                connectionString.Execute(sql, model);
            }
        }


        public void UpdateData<T>(T model, string sql)
        {
            throw new NotImplementedException();
        }
    }
}
