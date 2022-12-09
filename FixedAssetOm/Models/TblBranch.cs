using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblBranch
    {
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Fax { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int? Status { get; set; }
        public string? Cashaccount { get; set; }
        public string? SuspenseDr { get; set; }
        public string? SuspenseCr { get; set; }
        public string? InterBranchGl { get; set; }
        public int? BranchType { get; set; }
        public string? MbranchCode { get; set; }
        public string? SbranchCode { get; set; }
        public string? Userid { get; set; }
        public DateTime? CreateDt { get; set; }
        public string? Region { get; set; }
        public DateTime? Createdate { get; set; }
        public string? Authid { get; set; }
        public int? Subbranch { get; set; }
    }
}
