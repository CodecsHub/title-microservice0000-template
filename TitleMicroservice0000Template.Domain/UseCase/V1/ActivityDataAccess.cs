using System;
using System.Collections.Generic;
using System.Text;
using TitleMicroservice0000Template.Domain.Entities.V1;

namespace TitleMicroservice0000Template.Domain.UseCase.V1
{
    class ActivityDataAccess : IActivityDataAccess
    {
        ISqlDataAccess _database;

        public ActivityDataAccess(ISqlDataAccess database)
        {
            _database = database;
        }

        public void DeleteActivity(Activity model)
        {
            throw new NotImplementedException();
        }

        public List<Activity> GetActivityBy()
        {
            throw new NotImplementedException();
        }

        public List<Activity> GetAllActivity()
        {
            throw new NotImplementedException();
        }

        public void InsertActivity(Activity model)
        {
            string query = "EXEC V1Activity_Post @UserId, @ApplicationId, @ActionId" +
                            ", @ApplicationUrl, @ActivityRemarks, @DateTimeLog";

            _database.InsertData(model, query);
        }



        public void UpdateActivity(Activity model)
        {
            throw new NotImplementedException();
        }

    }
}
