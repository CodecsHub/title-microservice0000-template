using Dapper;
using FluentValidation.Results;
using Microservice00001TemplateAPI.DataAccessLayers;
using Microservice00001TemplateAPI.Models;
using Microservice00001TemplateAPI.Validators;
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



        public Task<List<V1Activity>> Get()
        {

            throw new NotImplementedException();

        }

        public Task<List<V1Activity>> Get(IIV1ActivityGetById model)
        {
            throw new NotImplementedException();
        }

        public Task<List<V1Activity>> Get(IIV1ActivityGetBySystemName model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<List<V1Activity>> Post(IIV1ActivityPost model)
        {

            IIV1ActivityPost validatingdata = new IIV1ActivityPost();
            // throw new NotImplementedException();
            ActivityValidator validator = new ActivityValidator();

            ValidationResult results = validator.Validate(validatingdata);

            //if (results.IsValid == false)
            //{
            //    foreach (ValidationFailure failure in results.Errors)
            //    {
            //        // errors.Add($"{failure.PropertyName} : {failure.ErrorMessage}");
            //      //  _database.InsertData(model, query);
            //      return "tsadf";
            //    }
            //}

            using (IDbConnection connection = new SqlConnection(_appSettings.Value.DatabaseConnectionWrite))
            {
                string query = "EXEC V1Activity_Post @SystemName, @ActionName, @UserName, @Remarks, @DateCreated";
                var output = await connection.QueryAsync<V1Activity>(query,
                        new
                        {
                            @SystemName = model.SystemName,
                            @ActionName = model.ActionName,
                            @UserName = model.UserName,
                            @Remarks = model.Remarks,
                            @DateCreated = model.DateCreated
                        }
                    );
                return output.ToList();
            }

        }


    }
}
