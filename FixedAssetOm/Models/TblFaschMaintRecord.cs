using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblFaschMaintRecord
    {
        public int Id { get; set; }
        public string? Facode { get; set; }
        public byte[] MaintDate { get; set; } = null!;
        public DateTime? NextMaintDate { get; set; }
        public int? Status { get; set; }
        public string? UserId { get; set; }
        public string? AuthId { get; set; }
    }
}
