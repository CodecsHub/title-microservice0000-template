using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice00001TemplateAPI.DataAccessLayers
{
    /// <summary>
    ///
    /// </summary>
    public class IIV1ActivityPost
    {
        public string SystemName { get; set; }
        public string ActionName { get; set; }
        public string UserName { get; set; }
        public string Remarks { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
