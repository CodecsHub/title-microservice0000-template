using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice00001TemplateAPI.DataAccessLayers
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T>(string sql);
        void InsertData<T>(T model, string sql);
        void UpdateData<T>(T model, string sql);
    }
}
