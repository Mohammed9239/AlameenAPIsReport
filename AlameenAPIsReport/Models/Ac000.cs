using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class Ac000
    {
        public int? Number { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? Cdate { get; set; }
        public int? Nsons { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? InitDebit { get; set; }
        public double? InitCredit { get; set; }
        public int? UseFlag { get; set; }
        public double? MaxDebit { get; set; }
        public string Notes { get; set; }
        public double? CurrencyVal { get; set; }
        public double? Warn { get; set; }
        public DateTime? CheckDate { get; set; }
        public int? Security { get; set; }
        public int? DebitOrCredit { get; set; }
        public int? Type { get; set; }
        public int? State { get; set; }
        public double? Num1 { get; set; }
        public double? Num2 { get; set; }
        public string LatinName { get; set; }
        public Guid Guid { get; set; }
        public Guid? ParentGuid { get; set; }
        public Guid? FinalGuid { get; set; }
        public Guid? CurrencyGuid { get; set; }
        public Guid? BranchGuid { get; set; }
        public long? BranchMask { get; set; }
        public int? IncomeType { get; set; }
        public int? CashFlowType { get; set; }
        public Guid? BalsheetGuid { get; set; }
        public bool? ForceCostCenter { get; set; }
        public Guid? CostGuid { get; set; }
        public Guid? AddedValueAccGuid { get; set; }
        public bool? IsUsingAddedValue { get; set; }
        public double? DefaultAddedValue { get; set; }
        public bool? IsDefaultAddedValueFixed { get; set; }
        public bool? IsSync { get; set; }
        public bool? IsChangeableRatio { get; set; }
        public bool? ConsiderChecksInBudget { get; set; }
        public bool? HideInSearch { get; set; }
        public string AccMenuName { get; set; }
        public string AccMenuLatinName { get; set; }
    }
}
