using System;
using System.Collections.Generic;
using System.Text;

namespace TitleMicroservice0000Template.Domain.DTO.V1
{
    public class IIActivityPost
    {
        public Int64 UserId { get; set; }
        public int ApplicationId { get; set; }
        public int ActionId { get; set; }
        public string ApplicationUrl { get; set; }
        public string ActivityRemarks { get; set; }
        public DateTime DateTimeLog { get; set; }
    }
}
