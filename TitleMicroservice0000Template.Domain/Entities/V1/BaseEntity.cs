using System;
using System.Collections.Generic;
using System.Text;

namespace TitleMicroservice0000Template.Domain.Entities.V1
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int RowVersion { get; set; }
        public int RowActive { get; set; }
    }
}
