using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class Bi000
    {
        public int? Number { get; set; }
        public double? Qty { get; set; }
        public double? Order { get; set; }
        public double? OrderQnt { get; set; }
        public double? Unity { get; set; }
        public double? Price { get; set; }
        public double? BonusQnt { get; set; }
        public double? Discount { get; set; }
        public double? BonusDisc { get; set; }
        public double? Extra { get; set; }
        public double? CurrencyVal { get; set; }
        public string Notes { get; set; }
        public double? Profits { get; set; }
        public double? Num1 { get; set; }
        public double? Num2 { get; set; }
        public double? Qty2 { get; set; }
        public double? Qty3 { get; set; }
        public string ClassPtr { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? ProductionDate { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public Guid Guid { get; set; }
        public double? Vat { get; set; }
        public double? Vatratio { get; set; }
        public Guid? ParentGuid { get; set; }
        public Guid? MatGuid { get; set; }
        public Guid? CurrencyGuid { get; set; }
        public Guid? StoreGuid { get; set; }
        public Guid? CostGuid { get; set; }
        public int? Sotype { get; set; }
        public Guid? Soguid { get; set; }
        public double? Count { get; set; }
        public int? Sogroup { get; set; }
        public double? TotalDiscountPercent { get; set; }
        public double? TotalExtraPercent { get; set; }
        public double? ClassPrice { get; set; }
        public double? MatCurVal { get; set; }
        public bool? IsDiscountValue { get; set; }
        public bool? IsExtraValue { get; set; }
        public int? TaxCode { get; set; }
        public double? ExciseTaxVal { get; set; }
        public double? PurchaseVal { get; set; }
        public double? ReversChargeVal { get; set; }
        public double? ExciseTaxPercent { get; set; }
        public int? ExciseTaxCode { get; set; }
        public double? Lcdisc { get; set; }
        public double? Lcextra { get; set; }
        public Guid? RelatedTo { get; set; }
        public double? CustomsRate { get; set; }
        public int? OrginalTaxCode { get; set; }
        public bool? IsPosspecialOffer { get; set; }
        public double? UnitCostPrice { get; set; }
        public double? Netprofit { get; set; }
        public double? NetprofitAfterTax { get; set; }
        public decimal? SalesTax { get; set; }
        public double? ReversChargeTaxRatio { get; set; }
        public string Barcode { get; set; }
    }
}
