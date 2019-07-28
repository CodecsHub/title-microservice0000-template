using Microservice00001TemplateAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice00001TemplateAPI.DataAccessLayers
{
    public interface IV1ActivityRepositories
    {
        Task<IEnumerable<V1Activity>> Getsss();
        Task<List<V1Activity>> Get(IIV1ActivityGetById model);
        Task<List<V1Activity>> Get(IIV1ActivityGetBySystemName model);
        Task<List<V1Activity>> Post(IIV1ActivityPost model);
    }
}
