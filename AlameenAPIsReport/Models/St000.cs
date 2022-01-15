using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class St000
    {
        public int? Number { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Address { get; set; }
        public string Keeper { get; set; }
        public int? Security { get; set; }
        public string LatinName { get; set; }
        public Guid Guid { get; set; }
        public Guid? ParentGuid { get; set; }
        public Guid? AccountGuid { get; set; }
        public int? Type { get; set; }
        public long? BranchMask { get; set; }
        public byte? Kind { get; set; }
        public double? StorageCapacity { get; set; }
        public bool? IsActive { get; set; }
        public int? PrinterId { get; set; }
        public string ExtraNote { get; set; }
    }
}
