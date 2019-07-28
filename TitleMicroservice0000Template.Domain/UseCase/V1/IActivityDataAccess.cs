using System;
using System.Collections.Generic;
using System.Text;
using TitleMicroservice0000Template.Domain.Entities.V1;

namespace TitleMicroservice0000Template.Domain.UseCase.V1
{
    public interface IActivityDataAccess
    {
        //List<Activity> GetAllActivity();
        //List<Activity> GetActivityBy();
        //void InsertActivity(Activity model);
        //void UpdateActivity(Activity model);
        //void DeleteActivity(Activity model);

        IEnumerable<Activity> GetAll();
        Activity Get(int id);
        Activity Add(Activity model);
        void Update(int id, Activity model);
        void Delete(int id);
    }
}
