using System;
using System.Collections.Generic;
using System.Text;

namespace TitleMicroservice0000Template.Domain.Entities.V1
{
    class Activity : BaseEntity
    {
        public Int64 UserId { get; set; }


        public int ApplicationId { get; set; }
        public int ActionId { get; set; }
        public string ApplicationUrl { get; set; }
        public string ActivityRemarks { get; set; }
    }
}
