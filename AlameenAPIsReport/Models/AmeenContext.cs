using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AlameenAPIsReport.Models
{
    public partial class AmeenContext : DbContext
    {
        public AmeenContext()
        {
        }

        public AmeenContext(DbContextOptions<AmeenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ac000> Ac000 { get; set; }
        public virtual DbSet<Bi000> Bi000 { get; set; }
        public virtual DbSet<Bt000> Bt000 { get; set; }
        public virtual DbSet<Bu000> Bu000 { get; set; }
        public virtual DbSet<Cu000> Cu000 { get; set; }
        public virtual DbSet<En000> En000 { get; set; }
        public virtual DbSet<Er000> Er000 { get; set; }
        public virtual DbSet<Et000> Et000 { get; set; }
        public virtual DbSet<Gr000> Gr000 { get; set; }
        public virtual DbSet<Mh000> Mh000 { get; set; }
        public virtual DbSet<Ms000> Ms000 { get; set; }
        public virtual DbSet<Mt000> Mt000 { get; set; }
        public virtual DbSet<My000> My000 { get; set; }
        public virtual DbSet<Myuser000> Myuser000 { get; set; }
        public virtual DbSet<Py000> Py000 { get; set; }
        public virtual DbSet<St000> St000 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ac000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__ac000__15B69B8E1A1401A1");

                entity.ToTable("ac000");

                entity.HasIndex(e => e.BranchGuid)
                    .HasName("ac000_ndx_7");

                entity.HasIndex(e => e.BranchMask)
                    .HasName("ac000_ndx_8");

                entity.HasIndex(e => e.Code)
                    .HasName("ac000_ndx_4");

                entity.HasIndex(e => e.FinalGuid)
                    .HasName("ac000_ndx_6");

                entity.HasIndex(e => e.Name)
                    .HasName("ac000_ndx_5");

                entity.HasIndex(e => e.Number)
                    .HasName("ac000_ndx_3");

                entity.HasIndex(e => new { e.Debit, e.Credit, e.ParentGuid })
                    .HasName("ac000_Key_1");

                entity.HasIndex(e => new { e.Number, e.Guid, e.BranchMask })
                    .HasName("ac000_Key_0");

                entity.HasIndex(e => new { e.Guid, e.ParentGuid, e.BranchMask, e.Type })
                    .HasName("ac000_Key_2");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccMenuLatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccMenuName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddedValueAccGuid)
                    .HasColumnName("AddedValueAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.BalsheetGuid).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.BranchGuid)
                    .HasColumnName("BranchGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.BranchMask)
                    .HasColumnName("branchMask")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CashFlowType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cdate)
                    .HasColumnName("CDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.Code)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConsiderChecksInBudget).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostGuid).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Credit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyGuid)
                    .HasColumnName("CurrencyGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CurrencyVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debit).HasDefaultValueSql("((0))");

                entity.Property(e => e.DebitOrCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultAddedValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalGuid)
                    .HasColumnName("FinalGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ForceCostCenter).HasDefaultValueSql("((0))");

                entity.Property(e => e.HideInSearch).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncomeType).HasDefaultValueSql("((0))");

                entity.Property(e => e.InitCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.InitDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsChangeableRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDefaultAddedValueFixed).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSync).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUsingAddedValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.LatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nsons)
                    .HasColumnName("NSons")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Num1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Num2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentGuid)
                    .HasColumnName("ParentGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Security).HasDefaultValueSql("((0))");

                entity.Property(e => e.State).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Warn).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bi000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__bi000__15B69B8F4766FFA7")
                    .IsClustered(false);

                entity.ToTable("bi000");

                entity.HasIndex(e => e.ClassPtr)
                    .HasName("bi000_ndx_54");

                entity.HasIndex(e => e.CostGuid)
                    .HasName("bi000_ndx_53");

                entity.HasIndex(e => e.ExpireDate)
                    .HasName("bi000_ndx_55");

                entity.HasIndex(e => e.Number)
                    .HasName("bi000_ndx_52");

                entity.HasIndex(e => e.ProductionDate)
                    .HasName("bi000_ndx_56");

                entity.HasIndex(e => e.Soguid)
                    .HasName("bi000_ndx_57");

                entity.HasIndex(e => new { e.ParentGuid, e.Number })
                    .HasName("bi000_Key_0")
                    .IsClustered();

                entity.HasIndex(e => new { e.Qty, e.Unity, e.BonusQnt, e.MatGuid, e.ParentGuid, e.Guid })
                    .HasName("bi000_Key_2");

                entity.HasIndex(e => new { e.Qty, e.Unity, e.BonusQnt, e.Guid, e.MatGuid, e.StoreGuid, e.Number, e.Price, e.Discount, e.BonusDisc, e.Extra, e.Qty2, e.Qty3, e.Lcdisc, e.Lcextra, e.ParentGuid, e.CostGuid })
                    .HasName("bi000_Key_3");

                entity.HasIndex(e => new { e.Number, e.Qty, e.Unity, e.Price, e.BonusQnt, e.Discount, e.BonusDisc, e.Extra, e.CurrencyVal, e.Qty2, e.Qty3, e.ClassPtr, e.ExpireDate, e.ProductionDate, e.Length, e.Width, e.Height, e.Vat, e.Vatratio, e.MatGuid, e.CurrencyGuid, e.StoreGuid, e.CostGuid, e.Count, e.ExciseTaxVal, e.ReversChargeVal, e.Profits, e.Guid, e.UnitCostPrice, e.Notes, e.ParentGuid })
                    .HasName("bi000_Key_4");

                entity.HasIndex(e => new { e.Number, e.Qty, e.Unity, e.Price, e.BonusQnt, e.Discount, e.BonusDisc, e.Extra, e.CurrencyVal, e.Notes, e.Profits, e.Qty2, e.Qty3, e.ClassPtr, e.ExpireDate, e.ProductionDate, e.Length, e.Width, e.Height, e.Guid, e.Vat, e.ParentGuid, e.StoreGuid, e.CurrencyGuid, e.CostGuid, e.Count, e.Lcdisc, e.Lcextra, e.Sotype, e.Soguid, e.ExciseTaxVal, e.ReversChargeVal, e.UnitCostPrice, e.MatGuid })
                    .HasName("bi000_Key_1");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BonusDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.BonusQnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassPtr)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CostGuid)
                    .HasColumnName("CostGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Count).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyGuid)
                    .HasColumnName("CurrencyGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CurrencyVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomsRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseTaxCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseTaxPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseTaxVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.Extra).HasDefaultValueSql("((0))");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDiscountValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsExtraValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPosspecialOffer)
                    .HasColumnName("IsPOSSpecialOffer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lcdisc)
                    .HasColumnName("LCDisc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lcextra)
                    .HasColumnName("LCExtra")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Length).HasDefaultValueSql("((0))");

                entity.Property(e => e.MatCurVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.MatGuid)
                    .HasColumnName("MatGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Netprofit).HasDefaultValueSql("((0))");

                entity.Property(e => e.NetprofitAfterTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Num1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Num2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderQnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrginalTaxCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentGuid)
                    .HasColumnName("ParentGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.Profits).HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty3).HasDefaultValueSql("((0))");

                entity.Property(e => e.RelatedTo).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ReversChargeTaxRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReversChargeVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesTax)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sogroup)
                    .HasColumnName("SOGroup")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Soguid)
                    .HasColumnName("SOGuid")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Sotype)
                    .HasColumnName("SOType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StoreGuid)
                    .HasColumnName("StoreGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.TaxCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalDiscountPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalExtraPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitCostPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vatratio)
                    .HasColumnName("VATRatio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bt000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__bt000__15B69B8E31A015B9");

                entity.ToTable("bt000");

                entity.HasIndex(e => e.BranchMask)
                    .HasName("bt000_ndx_104");

                entity.HasIndex(e => e.SortNum)
                    .HasName("bt000_ndx_103");

                entity.HasIndex(e => e.Type)
                    .HasName("bt000_ndx_102");

                entity.HasIndex(e => new { e.SortNum, e.Guid, e.BranchMask })
                    .HasName("bt000_Key_0");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BAffectCalcStoredQty)
                    .HasColumnName("bAffectCalcStoredQty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BAffectCostPrice)
                    .HasColumnName("bAffectCostPrice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BAffectCustPrice)
                    .HasColumnName("bAffectCustPrice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BAffectLastPrice)
                    .HasColumnName("bAffectLastPrice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BAffectProfit)
                    .HasColumnName("bAffectProfit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BAutoEntry)
                    .HasColumnName("bAutoEntry")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BAutoEntryPost)
                    .HasColumnName("bAutoEntryPost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BAutoPost)
                    .HasColumnName("bAutoPost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BBarCodeBill)
                    .HasColumnName("bBarCodeBill")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BCashBill)
                    .HasColumnName("bCashBill")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BCentringCustomerAccount)
                    .HasColumnName("bCentringCustomerAccount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BCollectCustAccount)
                    .HasColumnName("bCollectCustAccount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BContInv)
                    .HasColumnName("bContInv")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BContraCostToDiscount)
                    .HasColumnName("bContraCostToDiscount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BCostToCust)
                    .HasColumnName("bCostToCust")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BCostToDiscount)
                    .HasColumnName("bCostToDiscount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BCostToItems)
                    .HasColumnName("bCostToItems")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BCostToTaxAcc)
                    .HasColumnName("bCostToTaxAcc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BDiscAffectCost)
                    .HasColumnName("bDiscAffectCost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BDiscAffectProfit)
                    .HasColumnName("bDiscAffectProfit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BExtraAffectCost)
                    .HasColumnName("bExtraAffectCost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BExtraAffectProfit)
                    .HasColumnName("bExtraAffectProfit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BExtraToCash)
                    .HasColumnName("bExtraToCash")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BFixBranch)
                    .HasColumnName("bFixBranch")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BFixCurrency)
                    .HasColumnName("bFixCurrency")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BFixStore)
                    .HasColumnName("bFixStore")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BForceCost)
                    .HasColumnName("bForceCost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BForceCustomer)
                    .HasColumnName("bForceCustomer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BForceDate)
                    .HasColumnName("bForceDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BForcePayType)
                    .HasColumnName("bForcePayType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BForceSninRsales)
                    .HasColumnName("bForceSNInRSales")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BGenContraAcc)
                    .HasColumnName("bGenContraAcc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BIsInput)
                    .HasColumnName("bIsInput")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BIsOutput)
                    .HasColumnName("bIsOutput")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoCostFld)
                    .HasColumnName("bNoCostFld")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoDivideOrder)
                    .HasColumnName("bNoDivideOrder")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoEntry)
                    .HasColumnName("bNoEntry")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoExpiredDate)
                    .HasColumnName("bNoExpiredDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoGenerateCmd)
                    .HasColumnName("bNoGenerateCmd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoPost)
                    .HasColumnName("bNoPost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoPostCmd)
                    .HasColumnName("bNoPostCmd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoPrepareCmd)
                    .HasColumnName("bNoPrepareCmd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoSalesManFld)
                    .HasColumnName("bNoSalesManFld")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoStatFld)
                    .HasColumnName("bNoStatFld")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BNoVendorFld)
                    .HasColumnName("bNoVendorFld")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BPayTerms)
                    .HasColumnName("bPayTerms")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BPosbill)
                    .HasColumnName("bPOSBill")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BPrintReceipt)
                    .HasColumnName("bPrintReceipt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BRepeatedPhrase)
                    .HasColumnName("bRepeatedPhrase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BShortEntry)
                    .HasColumnName("bShortEntry")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BVataffectCost)
                    .HasColumnName("bVATAffectCost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BVataffectProfit)
                    .HasColumnName("bVATAffectProfit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BillGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.BillType).HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchMask)
                    .HasColumnName("branchMask")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Color1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Color2).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsideredGiftsOfSales).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustAccGuid).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefBillAccGuid)
                    .HasColumnName("DefBillAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefBonusAccGuid)
                    .HasColumnName("DefBonusAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefBonusContraAccGuid)
                    .HasColumnName("DefBonusContraAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefBonusPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefBranchGuid)
                    .HasColumnName("DefBranchGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefCashAccGuid)
                    .HasColumnName("DefCashAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefCostAccGuid)
                    .HasColumnName("DefCostAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefCostGuid)
                    .HasColumnName("DefCostGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefCostPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefCurrencyGuid)
                    .HasColumnName("DefCurrencyGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefDiscAccGuid)
                    .HasColumnName("DefDiscAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefExtraAccGuid)
                    .HasColumnName("DefExtraAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefMainAccount).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefStockAccGuid)
                    .HasColumnName("DefStockAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefStoreGuid)
                    .HasColumnName("DefStoreGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefVataccGuid)
                    .HasColumnName("DefVATAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefaultDeliveryDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultGroupGuid)
                    .HasColumnName("DefaultGroupGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefaultLocationGuid)
                    .HasColumnName("DefaultLocationGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ExciseAccGuid)
                    .HasColumnName("ExciseAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ExciseContraAccGuid)
                    .HasColumnName("ExciseContraAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.FixedDefaultValues).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldAvgPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldBarCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldBarCode2).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldBarCode3).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldBonusDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldClassPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldColor).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCompany).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldComposition).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCostPtr).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCurQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCurStoreQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCustPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCustomsRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldDefUnit).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldDefUnitFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldDiscRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldDiscValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldEndUserPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldExciseTaxVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldExpireDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldExportPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldExtraRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldExtraValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldGtipnumber).HasColumnName("FldGTIPNumber");

                entity.Property(e => e.FldHeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldLastPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldLatinName).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldMaxLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldMaxPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldMinLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldModel).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldName).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldNetprofit).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldNetprofitAfterTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldNotes).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldOrigin).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldPos).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldPriceIncludedTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldProdDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldProvenance).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldPurchaseValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldQty2).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldQty3).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldQuality).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldRetailPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldReverseChargeTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldSize).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldSpec).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldSpecialPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldStat).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldStore).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldTotalPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldType).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldUnit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldUnit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldUnit2Factor).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldUnit3).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldUnit3Factor).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldUnitPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldUnity).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldVat)
                    .HasColumnName("FldVAT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FldVatr)
                    .HasColumnName("FldVATR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FldVendorPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldWholePrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeTtcdiffOnSales)
                    .HasColumnName("IncludeTTCDiffOnSales")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsApplyTaxOnGifts)
                    .HasColumnName("isApplyTaxOnGifts")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDetermineCustomer).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPriceIncludeTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPriceOfferBill).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStopDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTimeScheduleEnabled).HasDefaultValueSql("((0))");

                entity.Property(e => e.KdvscenarioMode).HasColumnName("KDVScenarioMode");

                entity.Property(e => e.LatinAbbrev)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MenuLatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoAddExistBill).HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseMaxLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReverseChargesAccGuid)
                    .HasColumnName("ReverseChargesAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ReverseChargesContraAccGuid)
                    .HasColumnName("ReverseChargesContraAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ShowCustAddress).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowItemsCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowOrderEvaluation).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowQtyTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SortFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.SortNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.StopDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.StopDaysCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxBeforeDiscount)
                    .HasColumnName("taxBeforeDiscount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxBeforeExtra)
                    .HasColumnName("taxBeforeExtra")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalDiscRegardlessItemDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalExtraRegardlessItemExtra).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseExciseTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseReverseCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseSalesTax)
                    .HasColumnName("useSalesTax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vatsystem)
                    .HasColumnName("VATSystem")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bu000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__bu000__15B69B8F37485EEF")
                    .IsClustered(false);

                entity.ToTable("bu000");

                entity.HasIndex(e => e.CustomerAddressGuid)
                    .HasName("bu000_ndx_51");

                entity.HasIndex(e => e.Lcguid)
                    .HasName("bu000_ndx_50");

                entity.HasIndex(e => e.StoreGuid)
                    .HasName("bu000_ndx_49");

                entity.HasIndex(e => new { e.Guid, e.Number })
                    .HasName("bu000_Key_1");

                entity.HasIndex(e => new { e.Date, e.Number, e.TypeGuid })
                    .HasName("bu000_Key_2");

                entity.HasIndex(e => new { e.TypeGuid, e.Number, e.Branch })
                    .HasName("bu000_Key_0")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.Number, e.Date, e.CurrencyVal, e.Notes, e.Total, e.Guid, e.TypeGuid, e.CustGuid, e.CurrencyGuid, e.CustAccGuid, e.CostGuid, e.Branch })
                    .HasName("bu000_Key_3");

                entity.HasIndex(e => new { e.Number, e.CurrencyVal, e.TypeGuid, e.CurrencyGuid, e.CostGuid, e.MatAccGuid, e.CostAccGuid, e.BonusAccGuid, e.Total, e.ItemsDisc, e.IsPosted, e.Security, e.ItemsExtra, e.Lcguid, e.Date, e.Guid })
                    .HasName("bu000_Key_6");

                entity.HasIndex(e => new { e.Date, e.StoreGuid, e.CostGuid, e.Security, e.IsPosted, e.TypeGuid, e.Number, e.Branch, e.CustGuid, e.CurrencyVal, e.Total, e.ItemsDisc, e.Vat, e.CurrencyGuid, e.ItemsExtra, e.TotalExciseTax, e.TotalReversChargeTax, e.Guid })
                    .HasName("bu000_Key_7");

                entity.HasIndex(e => new { e.CurrencyVal, e.PayType, e.CurrencyGuid, e.Number, e.Notes, e.Total, e.TotalDisc, e.TotalExtra, e.ItemsDisc, e.BonusDisc, e.FirstPay, e.Security, e.Vendor, e.SalesManPtr, e.Branch, e.Guid, e.TypeGuid, e.CustGuid, e.CostGuid, e.ItemsExtra, e.Lcguid, e.Vat, e.TotalExciseTax, e.TotalReversChargeTax, e.IsPosted, e.Date, e.UserGuid })
                    .HasName("bu000_Key_5");

                entity.HasIndex(e => new { e.Number, e.Notes, e.Total, e.PayType, e.ItemsDisc, e.BonusDisc, e.FirstPay, e.IsPosted, e.Security, e.Vendor, e.SalesManPtr, e.Branch, e.Vat, e.Guid, e.TypeGuid, e.CustAccGuid, e.MatAccGuid, e.CostGuid, e.TextFld1, e.TextFld2, e.TextFld3, e.TextFld4, e.ItemsExtra, e.TotalSalesTax, e.CustName, e.CurrencyVal, e.TotalDisc, e.TotalExtra, e.CurrencyGuid, e.StoreGuid, e.CheckTypeGuid, e.TotalExciseTax, e.TotalReversChargeTax, e.CustGuid, e.Date })
                    .HasName("bu000_Key_4");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActivityTypeCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BonusAccGuid)
                    .HasColumnName("BonusAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.BonusContraAccGuid)
                    .HasColumnName("BonusContraAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.BonusDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.BonusDiscAccGuid)
                    .HasColumnName("BonusDiscAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Branch).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CalcBillVat).HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckTypeGuid)
                    .HasColumnName("CheckTypeGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CostAccGuid)
                    .HasColumnName("CostAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CostGuid)
                    .HasColumnName("CostGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.CreateUserGuid)
                    .HasColumnName("CreateUserGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CurrencyGuid)
                    .HasColumnName("CurrencyGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CurrencyVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustAccGuid)
                    .HasColumnName("CustAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CustGuid)
                    .HasColumnName("CustGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CustName)
                    .HasColumnName("Cust_Name")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustomerAddressGuid)
                    .HasColumnName("CustomerAddressGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.DeliveryTermCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EgpsubmissionUuid)
                    .HasColumnName("EGPSubmissionUUID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstPay).HasDefaultValueSql("((0))");

                entity.Property(e => e.FpayAccGuid)
                    .HasColumnName("FPayAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.GcclocationGuid)
                    .HasColumnName("GCCLocationGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Gtpnumber)
                    .HasColumnName("GTPNumber")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImportViaCustoms).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGeneratedByPocket).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTaxPayedByAgent).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemsDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemsDiscAccGuid)
                    .HasColumnName("ItemsDiscAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ItemsExtra).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemsExtraAccGuid)
                    .HasColumnName("ItemsExtraAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.KdvcurrencyVal)
                    .HasColumnName("KDVCurrencyVal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KdvinvoiceType).HasColumnName("KDVInvoiceType");

                entity.Property(e => e.KdvlastEventDate)
                    .HasColumnName("KDVLastEventDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.KdvscenarioType).HasColumnName("KDVScenarioType");

                entity.Property(e => e.KdvserialNumber)
                    .HasColumnName("KDVSerialNumber")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kdvstate).HasColumnName("KDVState");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.LastUpdateUserGuid)
                    .HasColumnName("LastUpdateUserGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Lcguid)
                    .HasColumnName("LCGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Lctype)
                    .HasColumnName("LCType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MatAccGuid)
                    .HasColumnName("MatAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Profits).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecState).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefundedBillGuid)
                    .HasColumnName("RefundedBillGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ReturendBillDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.ReturendBillNumber)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReversChargeReturn).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.SalesManPtr).HasDefaultValueSql("((0))");

                entity.Property(e => e.Security).HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialNumberCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StockAccGuid)
                    .HasColumnName("StockAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.StoreGuid)
                    .HasColumnName("StoreGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.TextFld1)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TextFld2)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TextFld3)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TextFld4)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalExciseTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalExtra).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalPurchaseVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalReversChargeTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSalesTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransportMode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TypeGuid)
                    .HasColumnName("TypeGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.UserGuid)
                    .HasColumnName("UserGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VataccGuid)
                    .HasColumnName("VATAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Vendor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Cu000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__cu000__15B69B8E849467F4");

                entity.ToTable("cu000");

                entity.HasIndex(e => e.AccountGuid)
                    .HasName("cu000_ndx_30");

                entity.HasIndex(e => e.CustomerName)
                    .HasName("cu000_ndx_29");

                entity.HasIndex(e => e.DefaultAddressGuid)
                    .HasName("cu000_ndx_31");

                entity.HasIndex(e => e.Number)
                    .HasName("cu000_ndx_28");

                entity.HasIndex(e => e.Phone1)
                    .HasName("cu000_ndx_32");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountGuid)
                    .HasColumnName("AccountGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.AddedValueAccountGuid)
                    .HasColumnName("AddedValueAccountGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.BHide)
                    .HasColumnName("bHide")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Certificate)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.ConditionalContraDiscAccGuid)
                    .HasColumnName("ConditionalContraDiscAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ConsiderChecksInBudget).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContraDiscAccGuid)
                    .HasColumnName("ContraDiscAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CostGuid)
                    .HasColumnName("CostGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Credit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.Debit).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefPrice).HasDefaultValueSql("(0x80)");

                entity.Property(e => e.DefaultAddressGuid)
                    .HasColumnName("DefaultAddressGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DiscRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExemptFromTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExemptionReasonCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gcccountry)
                    .HasColumnName("GCCCountry")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GcclocationGuid)
                    .HasColumnName("GCCLocationGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Glnflag)
                    .HasColumnName("GLNFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Head)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hoppies)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Job)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobCategory)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KdvagencyTaxName)
                    .HasColumnName("KDVAgencyTaxName")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KdvcommercialRegisterNumber)
                    .HasColumnName("KDVCommercialRegisterNumber")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kdvname)
                    .HasColumnName("KDVName")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KdvsurName)
                    .HasColumnName("KDVSurName")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nsemail1)
                    .HasColumnName("NSEMail1")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nsemail2)
                    .HasColumnName("NSEMail2")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NsemailUse)
                    .HasColumnName("NSEmailUse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nsmobile1)
                    .HasColumnName("NSMobile1")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nsmobile2)
                    .HasColumnName("NSMobile2")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NsnotSendEmail)
                    .HasColumnName("NSNotSendEmail")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NsnotSendSms)
                    .HasColumnName("NSNotSendSMS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NssmsUse)
                    .HasColumnName("NSSmsUse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.OfficialName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pager)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone2)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PictureGuid)
                    .HasColumnName("PictureGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReverseCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.Security).HasDefaultValueSql("((0))");

                entity.Property(e => e.State).HasDefaultValueSql("((0))");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telex)
                    .HasColumnName("TELEX")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserFld1)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserFld2)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserFld3)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserFld4)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Warn).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<En000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__en000__15B69B8F36FADB37")
                    .IsClustered(false);

                entity.ToTable("en000");

                entity.HasIndex(e => e.Class)
                    .HasName("en000_ndx_11");

                entity.HasIndex(e => e.CustomerGuid)
                    .HasName("en000_ndx_12");

                entity.HasIndex(e => e.Number)
                    .HasName("en000_ndx_10");

                entity.HasIndex(e => e.ParentGuid)
                    .HasName("en000_ndx_9")
                    .IsClustered();

                entity.HasIndex(e => new { e.CostGuid, e.CustomerGuid, e.Guid })
                    .HasName("en000_Key_1");

                entity.HasIndex(e => new { e.Date, e.AccountGuid, e.Guid, e.CustomerGuid })
                    .HasName("en000_Key_5");

                entity.HasIndex(e => new { e.Debit, e.Credit, e.AccountGuid, e.Date, e.Class, e.CostGuid, e.ParentGuid, e.CurrencyGuid, e.CurrencyVal })
                    .HasName("en000_Key_2");

                entity.HasIndex(e => new { e.Debit, e.Credit, e.Notes, e.CurrencyVal, e.Class, e.Guid, e.ParentGuid, e.AccountGuid, e.CurrencyGuid, e.CustomerGuid, e.CostGuid, e.Date })
                    .HasName("en000_Key_3");

                entity.HasIndex(e => new { e.Number, e.Debit, e.Credit, e.Notes, e.CurrencyVal, e.Guid, e.ParentGuid, e.CurrencyGuid, e.CostGuid, e.ContraAccGuid, e.Class, e.AccountGuid, e.CustomerGuid, e.Date })
                    .HasName("en000_Key_0");

                entity.HasIndex(e => new { e.Date, e.Debit, e.Credit, e.CurrencyVal, e.CurrencyGuid, e.Number, e.Notes, e.Class, e.Guid, e.CostGuid, e.ContraAccGuid, e.BiGuid, e.ParentGuid, e.AccountGuid, e.CustomerGuid })
                    .HasName("en000_Key_4");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountGuid)
                    .HasColumnName("AccountGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.AddedValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.BiGuid)
                    .HasColumnName("BiGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Class)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContraAccGuid)
                    .HasColumnName("ContraAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CostGuid)
                    .HasColumnName("CostGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Credit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyGuid)
                    .HasColumnName("CurrencyGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CurrencyVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerGuid)
                    .HasColumnName("CustomerGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.Debit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GccoriginDate)
                    .HasColumnName("GCCOriginDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.GccoriginNumber)
                    .HasColumnName("GCCOriginNumber")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lcguid)
                    .HasColumnName("LCGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Num1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Num2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentGuid)
                    .HasColumnName("ParentGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ParentVatguid)
                    .HasColumnName("ParentVATGuid")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.SalesMan).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Er000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__er000__15B69B8F66BB6667")
                    .IsClustered(false);

                entity.ToTable("er000");

                entity.HasIndex(e => new { e.EntryGuid, e.ParentGuid })
                    .HasName("er000_Key_0")
                    .IsClustered();

                entity.HasIndex(e => new { e.EntryGuid, e.ParentGuid, e.ParentType })
                    .HasName("er000_Key_1");

                entity.HasIndex(e => new { e.ParentGuid, e.ParentType, e.ParentNumber, e.EntryGuid })
                    .HasName("er000_Key_2");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EntryGuid)
                    .HasColumnName("EntryGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ParentGuid)
                    .HasColumnName("ParentGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ParentNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentType).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Et000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__et000__15B69B8EDE028025");

                entity.ToTable("et000");

                entity.HasIndex(e => e.BranchMask)
                    .HasName("et000_ndx_106");

                entity.HasIndex(e => e.SortNum)
                    .HasName("et000_ndx_105");

                entity.HasIndex(e => new { e.SortNum, e.Guid, e.BranchMask })
                    .HasName("et000_Key_0");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BAcceptCostAcc)
                    .HasColumnName("bAcceptCostAcc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BAutoPost)
                    .HasColumnName("bAutoPost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BCostToTaxAcc)
                    .HasColumnName("bCostToTaxAcc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BDetailed)
                    .HasColumnName("bDetailed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BRepeatedPhrase)
                    .HasColumnName("bRepeatedPhrase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchMask)
                    .HasColumnName("branchMask")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Color1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Color2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostForBothAcc).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrTerm)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DbTerm)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefAccGuid)
                    .HasColumnName("DefAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefBranchGuid)
                    .HasColumnName("DefBranchGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefCurrency).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.DefaultChequeTypeGuid)
                    .HasColumnName("DefaultChequeTypeGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.EntryGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryType).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedAccount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedBranch).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedCurrency).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldAccBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldAccCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldAccDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldAccFinal).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldAccName).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldAccParent).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldAddedValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldContraAcc).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCostPtr).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCurEqu).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCurName).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCurVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldCustomerName).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldGccoriginDate)
                    .HasColumnName("FldGCCOriginDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FldGccoriginNumber)
                    .HasColumnName("FldGCCOriginNumber")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FldLc)
                    .HasColumnName("FldLC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FldNotes).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldPaidState)
                    .HasColumnName("FLdPaidState")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FldSalesMan).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldStat).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldTaxValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.FldVendor).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForceChequeType).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForceCostCenter).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStopDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.LatinAbbrev)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MenuLatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReverseChargesAccGuid)
                    .HasColumnName("ReverseChargesAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ReverseChargesContraAccGuid)
                    .HasColumnName("ReverseChargesContraAccGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ShowDiscGrid).HasDefaultValueSql("((0))");

                entity.Property(e => e.SortNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.StopDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.TaxAccountGuid)
                    .HasColumnName("TaxAccountGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.TaxType).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseChequeTypes).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseReverseCharges).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Gr000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__gr000__15B69B8E6A2B1823");

                entity.ToTable("gr000");

                entity.HasIndex(e => e.BranchMask)
                    .HasName("gr000_ndx_48");

                entity.HasIndex(e => e.Code)
                    .HasName("gr000_ndx_45");

                entity.HasIndex(e => e.Name)
                    .HasName("gr000_ndx_46");

                entity.HasIndex(e => e.Number)
                    .HasName("gr000_ndx_44");

                entity.HasIndex(e => e.ParentGuid)
                    .HasName("gr000_ndx_47");

                entity.HasIndex(e => new { e.Number, e.Guid, e.BranchMask })
                    .HasName("gr000_Key_0");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchMask)
                    .HasColumnName("branchMask")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupMenuLatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupMenuName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kind).HasDefaultValueSql("((0))");

                entity.Property(e => e.LatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentGuid)
                    .HasColumnName("ParentGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.PictureGuid)
                    .HasColumnName("PictureGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Security).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Mh000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__mh000__15B69B8E54C645F5");

                entity.ToTable("mh000");

                entity.HasIndex(e => e.CurrencyGuid)
                    .HasName("mh000_ndx_128");

                entity.HasIndex(e => e.Date)
                    .HasName("mh000_ndx_129");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CurrencyGuid)
                    .HasColumnName("CurrencyGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CurrencyVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");
            });

            modelBuilder.Entity<Ms000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__ms000__15B69B8ED8DAF7C0");

                entity.ToTable("ms000");

                entity.HasIndex(e => new { e.Qty, e.MatGuid, e.StoreGuid })
                    .HasName("ms000_Key_1");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Book).HasDefaultValueSql("((0))");

                entity.Property(e => e.MatGuid)
                    .HasColumnName("MatGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.StoreGuid)
                    .HasColumnName("StoreGUID")
                    .HasDefaultValueSql("(0x00)");
            });

            modelBuilder.Entity<Mt000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__mt000__15B69B8E91CB0770");

                entity.ToTable("mt000");

                entity.HasIndex(e => e.BarCode)
                    .HasName("mt000_ndx_37");

                entity.HasIndex(e => e.BarCode2)
                    .HasName("mt000_ndx_39");

                entity.HasIndex(e => e.BarCode3)
                    .HasName("mt000_ndx_40");

                entity.HasIndex(e => e.BranchMask)
                    .HasName("mt000_ndx_41");

                entity.HasIndex(e => e.Code)
                    .HasName("mt000_ndx_34");

                entity.HasIndex(e => e.GroupGuid)
                    .HasName("mt000_ndx_38");

                entity.HasIndex(e => e.LatinName)
                    .HasName("mt000_ndx_36");

                entity.HasIndex(e => e.Name)
                    .HasName("mt000_ndx_35");

                entity.HasIndex(e => e.Number)
                    .HasName("mt000_ndx_33");

                entity.HasIndex(e => e.Parent)
                    .HasName("mt000_ndx_42");

                entity.HasIndex(e => new { e.Number, e.Guid, e.BranchMask })
                    .HasName("mt000_Key_0");

                entity.HasIndex(e => new { e.Security, e.GroupGuid, e.BranchMask })
                    .HasName("mt000_Key_2");

                entity.HasIndex(e => new { e.Security, e.Guid, e.GroupGuid, e.BranchMask, e.Type, e.HasSegments })
                    .HasName("mt000_Key_3");

                entity.HasIndex(e => new { e.Unit2Fact, e.Unit3Fact, e.Unit2FactFlag, e.Unit3FactFlag, e.Guid, e.BranchMask, e.ExpireFlag })
                    .HasName("mt000_Key_1");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Assemble).HasDefaultValueSql("((0))");

                entity.Property(e => e.AvgPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.BHide)
                    .HasColumnName("bHide")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BarCode2)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BarCode3)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.BonusOne).HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchMask)
                    .HasColumnName("branchMask")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CalPriceFromDetail).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodedCode)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Color)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Company)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompositionLatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompositionName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyGuid)
                    .HasColumnName("CurrencyGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CurrencyVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefUnit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dim)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DisableLastPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndUser2).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndUser3).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExemptionReasonCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpireFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Export).HasDefaultValueSql("((0))");

                entity.Property(e => e.Export2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Export3).HasDefaultValueSql("((0))");

                entity.Property(e => e.FirstCostDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.Flag).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForceInClass).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForceInExpire).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForceInSn)
                    .HasColumnName("ForceInSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ForceOutClass).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForceOutExpire).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForceOutSn)
                    .HasColumnName("ForceOutSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gpc)
                    .HasColumnName("GPC")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupGuid)
                    .HasColumnName("GroupGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Gtipnumber)
                    .HasColumnName("GTIPNumber")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Half).HasDefaultValueSql("((0))");

                entity.Property(e => e.Half2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Half3).HasDefaultValueSql("((0))");

                entity.Property(e => e.HasSegments).HasDefaultValueSql("((0))");

                entity.Property(e => e.High).HasDefaultValueSql("((0))");

                entity.Property(e => e.InheritsParentSpecs).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCalcTaxForPutaxCode)
                    .HasColumnName("IsCalcTaxForPUTaxCode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCompositionUpdated).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIntegerQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPrice2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPrice3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPriceCurVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPriceDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.LastPriceWithDiscAndExtra).HasDefaultValueSql("((0))");

                entity.Property(e => e.LatinName)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Low).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxPrice2).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxPrice3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Model)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewGuid)
                    .HasColumnName("NewGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.OldGuid)
                    .HasColumnName("OldGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.OrderLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Origin)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Parent).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.PictureGuid)
                    .HasColumnName("PictureGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Pos)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrevQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.PriceType).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductionFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Provenance)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quality)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Retail).HasDefaultValueSql("((0))");

                entity.Property(e => e.Retail2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Retail3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Security).HasDefaultValueSql("((0))");

                entity.Property(e => e.SellType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Snflag)
                    .HasColumnName("SNFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Spec)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit2)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Unit2Fact).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit2FactFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit3)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Unit3Fact).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit3FactFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unity)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UseFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendor).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendor2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendor3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Whole).HasDefaultValueSql("((0))");

                entity.Property(e => e.Whole2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Whole3).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<My000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__my000__15B69B8E2BA7646A");

                entity.ToTable("my000");

                entity.HasIndex(e => e.BranchMask)
                    .HasName("my000_ndx_17");

                entity.HasIndex(e => e.Code)
                    .HasName("my000_ndx_15");

                entity.HasIndex(e => e.Name)
                    .HasName("my000_ndx_16");

                entity.HasIndex(e => new { e.Number, e.Guid, e.BranchMask })
                    .HasName("my000_Key_0");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchMask)
                    .HasColumnName("branchMask")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrencyIso)
                    .HasColumnName("CurrencyISO")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrencyVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.LatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LatinPartName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PartPrecision).HasDefaultValueSql("((0))");

                entity.Property(e => e.PictureGuid)
                    .HasColumnName("PictureGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Security).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Myuser000>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("myuser000");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Py000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__py000__15B69B8EFDAE5598");

                entity.ToTable("py000");

                entity.HasIndex(e => e.BranchGuid)
                    .HasName("py000_ndx_27");

                entity.HasIndex(e => e.Date)
                    .HasName("py000_ndx_26");

                entity.HasIndex(e => e.Number)
                    .HasName("py000_ndx_25");

                entity.HasIndex(e => new { e.TypeGuid, e.Number, e.BranchGuid })
                    .HasName("py000_Key_0")
                    .IsUnique();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountGuid)
                    .HasColumnName("AccountGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.BranchGuid)
                    .HasColumnName("BranchGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ChequeTypeGuid)
                    .HasColumnName("ChequeTypeGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CostGuid)
                    .HasColumnName("CostGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.CreateUserGuid).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CurrencyGuid)
                    .HasColumnName("CurrencyGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.CurrencyVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerGuid).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/1980')");

                entity.Property(e => e.LastUpdateUserGuid).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Num1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Num2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.Security).HasDefaultValueSql("((0))");

                entity.Property(e => e.Skip).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeGuid)
                    .HasColumnName("TypeGUID")
                    .HasDefaultValueSql("(0x00)");
            });

            modelBuilder.Entity<St000>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__st000__15B69B8E19FD65C1");

                entity.ToTable("st000");

                entity.HasIndex(e => e.BranchMask)
                    .HasName("st000_ndx_65");

                entity.HasIndex(e => e.Code)
                    .HasName("st000_ndx_62");

                entity.HasIndex(e => e.Name)
                    .HasName("st000_ndx_63");

                entity.HasIndex(e => e.Number)
                    .HasName("st000_ndx_61");

                entity.HasIndex(e => e.ParentGuid)
                    .HasName("st000_ndx_64");

                entity.HasIndex(e => new { e.Number, e.Guid, e.BranchMask })
                    .HasName("st000_Key_0");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountGuid)
                    .HasColumnName("AccountGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchMask)
                    .HasColumnName("branchMask")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExtraNote)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Keeper)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kind).HasDefaultValueSql("((0))");

                entity.Property(e => e.LatinName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentGuid)
                    .HasColumnName("ParentGUID")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.PrinterId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Security).HasDefaultValueSql("((0))");

                entity.Property(e => e.StorageCapacity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
