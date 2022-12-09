using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblDepartment
    {
        public string Deptid { get; set; } = null!;
        public string? DeptName { get; set; }
        public string? DeptShortname { get; set; }
        public int? Status { get; set; }
        public string? Userid { get; set; }
        public string? Authid { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
