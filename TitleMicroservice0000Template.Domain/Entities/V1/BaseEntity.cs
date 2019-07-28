using System;
using System.Collections.Generic;
using System.Text;

namespace TitleMicroservice0000Template.Domain.Entities.V1
{
    public class BaseEntity
    {

        private DateTime _dateCreated;
        private DateTime _dateUpdated;
        private int _rowVersion;
        private int _rowActive;

        public Int64 Id { get; set; }
        public DateTime DateTimeLog { get; set; }
        public DateTime DateCreated
        {
            get => _dateCreated;
            //set => _dateCreated = DateTimeLog;
        }
        public DateTime DateUpdated {
            get => _dateUpdated;
           // set => _dateUpdated = DateTimeLog;
        }
        public int RowVersion {
            get => _rowVersion;
            set => _rowVersion = 1;
        }
        public int RowActive
        {
            get => _rowActive;
            set => _rowActive = 1;
        }
    }
}
