using System;
using System.Collections.Generic;
using System.Text;

namespace TitleMicroservice0000Template.Domain.Entities.V1
{
    public class User : BaseEntity
    {
        public string AzureId { get; set; }
        public string UserName { get; set; }
    }
}
