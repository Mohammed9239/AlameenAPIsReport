using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class Gr000
    {
        public int? Number { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int? Security { get; set; }
        public Guid Guid { get; set; }
        public int? Type { get; set; }
        public double? Vat { get; set; }
        public string LatinName { get; set; }
        public Guid? ParentGuid { get; set; }
        public long? BranchMask { get; set; }
        public byte? Kind { get; set; }
        public Guid? PictureGuid { get; set; }
        public string GroupMenuName { get; set; }
        public string GroupMenuLatinName { get; set; }
    }
}
