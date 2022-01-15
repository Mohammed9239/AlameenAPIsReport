using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class En000
    {
        public int? Number { get; set; }
        public DateTime? Date { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public string Notes { get; set; }
        public double? CurrencyVal { get; set; }
        public string Class { get; set; }
        public double? Num1 { get; set; }
        public double? Num2 { get; set; }
        public double? Vendor { get; set; }
        public double? SalesMan { get; set; }
        public Guid Guid { get; set; }
        public Guid? ParentGuid { get; set; }
        public Guid? AccountGuid { get; set; }
        public Guid? CurrencyGuid { get; set; }
        public Guid? CostGuid { get; set; }
        public Guid? ContraAccGuid { get; set; }
        public double? AddedValue { get; set; }
        public Guid? ParentVatguid { get; set; }
        public Guid? BiGuid { get; set; }
        public int? Type { get; set; }
        public Guid? Lcguid { get; set; }
        public Guid? CustomerGuid { get; set; }
        public DateTime? GccoriginDate { get; set; }
        public string GccoriginNumber { get; set; }
    }
}
