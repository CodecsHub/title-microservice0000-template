using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Microservice00001TemplateAPI.Models
{
    /// <summary>
    ///  Version 1 of Activity data
    /// </summary>
    public class V1Activity
    {
        // check this in the string object
        //SkillsValidate(Allowed = new string[] { "ASP.NET Core", "ASP.NET MVC", "ASP.NET Web Forms" }, ErrorMessage = "You skills are invalid")]
        // check this in integer object   [Range(5, 50)]

        public long AudAuditIditId { get; set; }



        public string SystemName { get; set; }


        public string ActionName { get; set; }


        public string UserName { get; set; }


        public string Remarks { get; set; }


        public DateTime DateCreated { get; set; }
    }
}
