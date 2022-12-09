using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblFaancilaryCost
    {
        public int Id { get; set; }
        public string? CostCode { get; set; }
        public string? CostDesc { get; set; }
        public int? Capitalized { get; set; }
        public int? Status { get; set; }
        public string? UserId { get; set; }
        public string? AuthId { get; set; }
    }
}
