using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblFadepSchedule
    {
        public int Id { get; set; }
        public string? AssetCode { get; set; }
        public int? Installment { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? YearlyDep { get; set; }
        public decimal? MonthlyDep { get; set; }
        public int? Status { get; set; }
    }
}
