using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblFixedAsset
    {
        public int Id { get; set; }
        public string? CatCode { get; set; }
        public string? ClassCode { get; set; }
        public string? Facode { get; set; }
        public string? Faname { get; set; }
        public int? DepMethod { get; set; }
        public decimal? Deprate { get; set; }
        public int? LifeSpan { get; set; }
        public string? LocationCode { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public byte[] TranDate { get; set; } = null!;
        public decimal? Facost { get; set; }
        public decimal? ResidualVal { get; set; }
        public decimal? AccumDep { get; set; }
        public int? LifeSpanUsed { get; set; }
        public DateTime? DepStartDate { get; set; }
        public string? Faglaccount { get; set; }
        public string? FundingGl { get; set; }
        public string? AccumDepGl { get; set; }
        public string? ExpenseGl { get; set; }
        public int? Status { get; set; }
        public int? DisposalMethod { get; set; }
        public decimal? DisposalAmt { get; set; }
        public string? UserId { get; set; }
        public string? AuthId { get; set; }
    }
}
