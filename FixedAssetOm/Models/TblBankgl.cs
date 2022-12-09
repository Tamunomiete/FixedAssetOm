using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblBankgl
    {
        public string Glnumber { get; set; } = null!;
        public string? AcctName { get; set; }
        public string? BranchCode { get; set; }
        public string? GlClassCode { get; set; }
        public string? CurrencyCode { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? DtLstMonth { get; set; }
        public decimal? LastMonthBalance { get; set; }
        public int? Status { get; set; }
        public decimal? LastNightBalance { get; set; }
        public decimal? Bkbalance { get; set; }
        public decimal? TpostDebit { get; set; }
        public decimal? TpostCredit { get; set; }
        public string? Blocked { get; set; }
        public string? Closed { get; set; }
        public int? ReconLen { get; set; }
        public int? Post { get; set; }
        public decimal? Bbf { get; set; }
        public string? ProdType { get; set; }
        public int? Pointing { get; set; }
        public string? TypeP { get; set; }
        public string? Userid { get; set; }
        public string? Authid { get; set; }
        public DateTime? Createdate { get; set; }
        public int? Populate { get; set; }
        public string? OldGlno { get; set; }
        public decimal? LastNightBalance2 { get; set; }
        public int? Swing { get; set; }
        public decimal? LastMonthBalance2 { get; set; }
        public decimal? LastMonthBalance1 { get; set; }
        public DateTime? LastEom2 { get; set; }
        public DateTime? LastEom1 { get; set; }
        public decimal? Currmondiff { get; set; }
        public decimal? Lastmondiff { get; set; }
        public int? Controlflag { get; set; }
        public int? ControlGlag { get; set; }
    }
}
