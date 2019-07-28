using System;
using System.Collections.Generic;
using System.Text;
using TitleMicroservice0000Template.Domain.Entities.V1;

namespace TitleMicroservice0000Template.Domain.UseCase.V1
{
    public class ActivityDataAccess : IActivityDataAccess
    {
        ISqlDataAccess _database;

        public ActivityDataAccess(ISqlDataAccess database)
        {
            _database = database;
        }

        public Activity Add(Activity model)
        {
            string query = "EXEC V1Activity_Post @UserId, @ApplicationId, @ActionId" +
                     ", @ApplicationUrl, @ActivityRemarks, @DateTimeLog";

            _database.InsertData(model, query);

            return model;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Activity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetAll()
        {
            //string query = "SELECT * FROM Activity";

            //_database.GetAllData(model, query);

            //return model;
            throw new NotImplementedException();
        }

        public void Update(int id, Activity person)
        {
            throw new NotImplementedException();
        }
    }
}
