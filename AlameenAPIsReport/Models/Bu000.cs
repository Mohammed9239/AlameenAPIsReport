using System;
using System.Collections.Generic;

namespace AlameenAPIsReport.Models
{
    public partial class Bu000
    {
        public int? Number { get; set; }
        public string CustName { get; set; }
        public DateTime? Date { get; set; }
        public double? CurrencyVal { get; set; }
        public string Notes { get; set; }
        public double? Total { get; set; }
        public int? PayType { get; set; }
        public double? TotalDisc { get; set; }
        public double? TotalExtra { get; set; }
        public double? ItemsDisc { get; set; }
        public double? BonusDisc { get; set; }
        public double? FirstPay { get; set; }
        public double? Profits { get; set; }
        public int? IsPosted { get; set; }
        public int? Security { get; set; }
        public double? Vendor { get; set; }
        public double? SalesManPtr { get; set; }
        public Guid? Branch { get; set; }
        public double? Vat { get; set; }
        public Guid Guid { get; set; }
        public Guid? TypeGuid { get; set; }
        public Guid? CustGuid { get; set; }
        public Guid? CurrencyGuid { get; set; }
        public Guid? StoreGuid { get; set; }
        public Guid? CustAccGuid { get; set; }
        public Guid? MatAccGuid { get; set; }
        public Guid? ItemsDiscAccGuid { get; set; }
        public Guid? BonusDiscAccGuid { get; set; }
        public Guid? FpayAccGuid { get; set; }
        public Guid? CostGuid { get; set; }
        public Guid? UserGuid { get; set; }
        public Guid? CheckTypeGuid { get; set; }
        public string TextFld1 { get; set; }
        public string TextFld2 { get; set; }
        public string TextFld3 { get; set; }
        public string TextFld4 { get; set; }
        public int? RecState { get; set; }
        public double? ItemsExtra { get; set; }
        public Guid? ItemsExtraAccGuid { get; set; }
        public Guid? CostAccGuid { get; set; }
        public Guid? StockAccGuid { get; set; }
        public Guid? VataccGuid { get; set; }
        public Guid? BonusAccGuid { get; set; }
        public Guid? BonusContraAccGuid { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsGeneratedByPocket { get; set; }
        public bool? CalcBillVat { get; set; }
        public double? TotalSalesTax { get; set; }
        public double? TotalExciseTax { get; set; }
        public Guid? RefundedBillGuid { get; set; }
        public double? IsTaxPayedByAgent { get; set; }
        public Guid? Lcguid { get; set; }
        public int? Lctype { get; set; }
        public Guid? ReversChargeReturn { get; set; }
        public string ReturendBillNumber { get; set; }
        public DateTime? ReturendBillDate { get; set; }
        public bool? ImportViaCustoms { get; set; }
        public double? TotalReversChargeTax { get; set; }
        public double? TotalPurchaseVal { get; set; }
        public Guid? CreateUserGuid { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? LastUpdateUserGuid { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public Guid? GcclocationGuid { get; set; }
        public Guid? CustomerAddressGuid { get; set; }
        public string KdvserialNumber { get; set; }
        public byte Kdvstate { get; set; }
        public DateTime? KdvlastEventDate { get; set; }
        public byte KdvscenarioType { get; set; }
        public byte KdvinvoiceType { get; set; }
        public string ActivityTypeCode { get; set; }
        public string EgpsubmissionUuid { get; set; }
        public double? KdvcurrencyVal { get; set; }
        public string DeliveryTermCode { get; set; }
        public string TransportMode { get; set; }
        public string Gtpnumber { get; set; }
        public int? SerialNumber { get; set; }
        public string SerialNumberCode { get; set; }
    }
}
