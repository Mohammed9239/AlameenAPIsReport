using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class Mh000
    {
        public Guid Guid { get; set; }
        public Guid? CurrencyGuid { get; set; }
        public double? CurrencyVal { get; set; }
        public DateTime? Date { get; set; }
    }
}
