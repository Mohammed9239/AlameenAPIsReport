using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class Et000
    {
        public Guid Guid { get; set; }
        public int? SortNum { get; set; }
        public int? EntryGroup { get; set; }
        public int? EntryType { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
        public string Abbrev { get; set; }
        public string LatinAbbrev { get; set; }
        public string DbTerm { get; set; }
        public string CrTerm { get; set; }
        public int? Color1 { get; set; }
        public int? Color2 { get; set; }
        public bool? BAcceptCostAcc { get; set; }
        public bool? BAutoPost { get; set; }
        public bool? BDetailed { get; set; }
        public int? FldAccName { get; set; }
        public int? FldDebit { get; set; }
        public int? FldCredit { get; set; }
        public int? FldNotes { get; set; }
        public int? FldCurName { get; set; }
        public int? FldCurVal { get; set; }
        public int? FldStat { get; set; }
        public int? FldCostPtr { get; set; }
        public int? FldDate { get; set; }
        public int? FldVendor { get; set; }
        public int? FldSalesMan { get; set; }
        public int? FldAccParent { get; set; }
        public int? FldAccFinal { get; set; }
        public int? FldAccCredit { get; set; }
        public int? FldAccDebit { get; set; }
        public int? FldAccBalance { get; set; }
        public int? FldContraAcc { get; set; }
        public Guid? DefAccGuid { get; set; }
        public long? BranchMask { get; set; }
        public int? FldCurEqu { get; set; }
        public bool? ShowDiscGrid { get; set; }
        public bool? CostForBothAcc { get; set; }
        public string MenuName { get; set; }
        public string MenuLatinName { get; set; }
        public Guid? DefCurrency { get; set; }
        public bool? FixedAccount { get; set; }
        public bool? FixedCurrency { get; set; }
        public Guid? DefBranchGuid { get; set; }
        public bool? FixedNumber { get; set; }
        public bool? FixedBranch { get; set; }
        public bool? FixedDate { get; set; }
        public bool? IsStopDate { get; set; }
        public DateTime? StopDate { get; set; }
        public bool? BRepeatedPhrase { get; set; }
        public bool? ForceCostCenter { get; set; }
        public int? FldAddedValue { get; set; }
        public byte? TaxType { get; set; }
        public Guid? TaxAccountGuid { get; set; }
        public int? FldTaxValue { get; set; }
        public int? FldLc { get; set; }
        public int? FldCustomerName { get; set; }
        public Guid? ReverseChargesAccGuid { get; set; }
        public Guid? ReverseChargesContraAccGuid { get; set; }
        public bool? UseReverseCharges { get; set; }
        public int? FldGccoriginDate { get; set; }
        public int? FldGccoriginNumber { get; set; }
        public int? FldPaidState { get; set; }
        public bool? BCostToTaxAcc { get; set; }
        public bool? UseChequeTypes { get; set; }
        public Guid? DefaultChequeTypeGuid { get; set; }
        public bool? ForceChequeType { get; set; }
    }
}
