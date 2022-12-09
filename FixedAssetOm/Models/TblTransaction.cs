using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblTransaction
    {
        public string AccountNumber { get; set; } = null!;
        public string Trancode { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public string? TranCurrency { get; set; }
        public DateTime TranDate { get; set; }
        public DateTime Valuedate { get; set; }
        public string Userid { get; set; } = null!;
        public string Narration { get; set; } = null!;
        public decimal? TranAmount { get; set; }
        public decimal? BaseAmount { get; set; }
        public decimal Charge { get; set; }
        public int? Reversal { get; set; }
        public int AccountModule { get; set; }
        public decimal? Tellerno { get; set; }
        public string? Subbranchcode { get; set; }
        public string? Deptcode { get; set; }
        public string? Authid { get; set; }
        public int? Status { get; set; }
        public decimal? Batchno { get; set; }
        public string? Overideid { get; set; }
        public string? Refno { get; set; }
        public long? ReversedTranRef { get; set; }
        public int? MenuId { get; set; }
        public long? ExceptionRef { get; set; }
        public string? AccountType { get; set; }
        public int? ControlFlag { get; set; }
        public string? TranType { get; set; }
        public string? Branchcode { get; set; }
        public decimal? Postseq { get; set; }
        public decimal? Crossrate { get; set; }
        public decimal? Chknum { get; set; }
        public long Sn { get; set; }
        public string? Channel { get; set; }
    }
}
