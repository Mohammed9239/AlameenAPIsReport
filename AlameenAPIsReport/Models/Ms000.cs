using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class Ms000
    {
        public double? Qty { get; set; }
        public double? Book { get; set; }
        public Guid Guid { get; set; }
        public Guid? StoreGuid { get; set; }
        public Guid? MatGuid { get; set; }
    }
}
