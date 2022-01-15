using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class Er000
    {
        public Guid Guid { get; set; }
        public Guid? EntryGuid { get; set; }
        public Guid? ParentGuid { get; set; }
        public int? ParentType { get; set; }
        public int? ParentNumber { get; set; }
    }
}
