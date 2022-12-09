using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblFaclass
    {
        public int Id { get; set; }
        public string? CatCode { get; set; } 
        public string? ClassCode { get; set; }
        public string? ClassName { get; set; }
        public string? DepMethod { get; set; }
        public decimal? DepRate { get; set; }
        public int? LifeSpan { get; set; }
        public int? Status { get; set; }
        public string? UserId { get; set; }
        public string? AuthId { get; set; }
    }
}
