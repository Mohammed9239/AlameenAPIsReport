using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class Py000
    {
        public int? Number { get; set; }
        public DateTime? Date { get; set; }
        public string Notes { get; set; }
        public double? CurrencyVal { get; set; }
        public int? Skip { get; set; }
        public double? Security { get; set; }
        public double? Num1 { get; set; }
        public double? Num2 { get; set; }
        public Guid Guid { get; set; }
        public Guid? TypeGuid { get; set; }
        public Guid? AccountGuid { get; set; }
        public Guid? CurrencyGuid { get; set; }
        public Guid? BranchGuid { get; set; }
        public Guid? CreateUserGuid { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? LastUpdateUserGuid { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public Guid? CustomerGuid { get; set; }
        public Guid? ChequeTypeGuid { get; set; }
        public Guid? CostGuid { get; set; }
    }
}
