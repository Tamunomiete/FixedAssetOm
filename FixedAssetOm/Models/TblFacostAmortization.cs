using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblFacostAmortization
    {
        public int Id { get; set; }
        public string? FaCode { get; set; }
        public string? CostCode { get; set; }
        public decimal? MonthlyAmortization { get; set; }
        public int? Tenor { get; set; }
        public int? CapitalizedType { get; set; }
        public decimal? AccumAmortization { get; set; }
        public DateTime? NextAmortDate { get; set; }
        public int? Status { get; set; }
    }
}
