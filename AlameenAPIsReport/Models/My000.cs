using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class My000
    {
        public int? Number { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double? CurrencyVal { get; set; }
        public string PartName { get; set; }
        public int? PartPrecision { get; set; }
        public DateTime? Date { get; set; }
        public int? Security { get; set; }
        public string LatinName { get; set; }
        public string LatinPartName { get; set; }
        public Guid Guid { get; set; }
        public long? BranchMask { get; set; }
        public Guid? PictureGuid { get; set; }
        public string CurrencyIso { get; set; }
    }
}
