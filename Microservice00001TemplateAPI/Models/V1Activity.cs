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
        [Required(ErrorMessage = "Activity Id.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Invalid Audit Id input.")]
        public long AudAuditIditId { get; set; }


        [Required(ErrorMessage = "System Name is required.")]
        public string SystemName { get; set; }

        [Required(ErrorMessage = "ActionName is required.")]
        public string ActionName { get; set; }

        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; set; }


        public string Remarks { get; set; }


        public DateTime TimeLog { get; set; }
    }
}
