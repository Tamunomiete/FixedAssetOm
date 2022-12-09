using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblFarecuringAmortSchedule
    {
        public int Id { get; set; }
        public string? Facode { get; set; }
        public string? CostCode { get; set; }
        public decimal? MonthlyRunRate { get; set; }
        public DateTime? NextAmortDate { get; set; }
        public int? Tenor { get; set; }
        public int? TenorSpent { get; set; }
        public int? Status { get; set; }
    }
}
