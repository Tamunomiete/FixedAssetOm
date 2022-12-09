using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblFalocation
    {
        public int Id { get; set; }
        public string? Facode { get; set; }
        public string? FalocationCode { get; set; }
        public byte[] DateAllocated { get; set; } = null!;
        public int? Status { get; set; }
        public int? ReceiptStatus { get; set; }
        public string? UserId { get; set; }
        public string? AuthId { get; set; }
        public string? ReceiptBy { get; set; }
        public string? AssetGl { get; set; }
        public string? AccumDepGl { get; set; }
        public string? DepExpenseGl { get; set; }
    }
}
