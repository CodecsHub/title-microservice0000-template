using System;
using System.Collections.Generic;
using System.Text;

namespace TitleMicroservice0000Template.Domain.UseCase.V1
{
    public interface ISqlDataAccess
    {
        List<T> GetAllData<T>(T model, string sql);
        List<T> GetDataBy<T>(T model, string sql);
        void InsertData<T>(T model, string sql);
        void UpdateData<T>(T model, string sql);
        void DeleteData<T>(T model, string sql);
    }
}
